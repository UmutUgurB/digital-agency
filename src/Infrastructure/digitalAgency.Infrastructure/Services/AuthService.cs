using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Dtos.Auth;
using digitalAgency.Application.Repositories;
using digitalAgency.Application.Settings;
using digitalAgency.Domain.Entities;
using digitalAgency.Domain.Exceptions;
using Microsoft.Extensions.Options;

namespace digitalAgency.Infrastructure.Services
{
    /// <summary>
    /// Authentication servisi implementation
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtSettings _jwtSettings;

        public AuthService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IUnitOfWork unitOfWork,
            IOptions<JwtSettings> jwtSettings)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _unitOfWork = unitOfWork;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<AuthResponseDto> LoginAsync(string email, string password, CancellationToken cancellationToken = default)
        {
            // Kullanıcıyı bul
            var user = await _userRepository.GetByEmailWithRolesAsync(email, cancellationToken);
            
            if (user == null)
                throw new AuthenticationException("Email veya şifre hatalı.");

            // Kullanıcı aktif mi?
            if (!user.IsActive)
                throw new AuthenticationException("Hesabınız devre dışı bırakılmış.");

            // Hesap kilitli mi?
            if (user.IsLockedOut)
                throw new AuthenticationException($"Hesabınız {user.LockoutEnd:dd.MM.yyyy HH:mm} tarihine kadar kilitlenmiştir.");

            // Şifre doğrula
            if (!_passwordHasher.VerifyPassword(password, user.PasswordHash))
            {
                // Başarısız login denemesi artır
                user.FailedLoginAttempts++;
                
                // 5 başarısız denemede hesabı kilitle (15 dakika)
                if (user.FailedLoginAttempts >= 5)
                {
                    user.LockoutEnd = DateTime.UtcNow.AddMinutes(15);
                    user.FailedLoginAttempts = 0;
                    await _unitOfWork.SaveChangesAsync(cancellationToken);
                    throw new AuthenticationException("Çok fazla başarısız deneme. Hesabınız 15 dakika süreyle kilitlendi.");
                }

                await _unitOfWork.SaveChangesAsync(cancellationToken);
                throw new AuthenticationException("Email veya şifre hatalı.");
            }

            // Başarılı login - failed attempts sıfırla
            user.FailedLoginAttempts = 0;
            user.LastLoginDate = DateTime.UtcNow;

            // Rolleri al
            var roles = user.UserRoles.Select(ur => ur.Role.Name).ToList();

            // Token oluştur
            var accessToken = _tokenService.GenerateAccessToken(user, roles);
            var refreshToken = _tokenService.GenerateRefreshToken();

            // Refresh token'ı kaydet
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationDays);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new AuthResponseDto
            {
                UserId = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                AccessTokenExpiration = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes),
                RefreshTokenExpiration = user.RefreshTokenExpiryTime.Value,
                Roles = roles
            };
        }

        public async Task<AuthResponseDto> RegisterAsync(string email, string password, string firstName, string lastName, CancellationToken cancellationToken = default)
        {
            // Email zaten kullanılıyor mu?
            if (await _userRepository.IsEmailExistsAsync(email, cancellationToken))
                throw new BusinessException("Bu email adresi zaten kullanılıyor.");

            // Yeni kullanıcı oluştur
            var user = new User
            {
                Email = email.ToLowerInvariant(),
                PasswordHash = _passwordHasher.HashPassword(password),
                FirstName = firstName,
                LastName = lastName,
                IsActive = true,
                EmailConfirmed = false // Email confirmation eklenebilir
            };

            await _userRepository.AddAsync(user, cancellationToken);

            // Default "User" rolünü ekle
            var userRole = await _roleRepository.GetByNameAsync("User", cancellationToken);
            if (userRole != null)
            {
                user.UserRoles.Add(new UserRole
                {
                    UserId = user.Id,
                    RoleId = userRole.Id
                });
            }

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            // Otomatik login
            return await LoginAsync(email, password, cancellationToken);
        }

        public async Task<AuthResponseDto> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            // Refresh token ile kullanıcıyı bul
            var user = await _userRepository.GetByRefreshTokenAsync(refreshToken, cancellationToken);

            if (user == null || user.RefreshToken != refreshToken)
                throw new AuthenticationException("Geçersiz refresh token.");

            // Token süresi dolmuş mu?
            if (user.RefreshTokenExpiryTime < DateTime.UtcNow)
                throw new AuthenticationException("Refresh token süresi dolmuş. Lütfen tekrar giriş yapın.");

            // Kullanıcı rolleri ile birlikte yükle
            user = await _userRepository.GetByIdWithRolesAsync(user.Id, cancellationToken);
            var roles = user!.UserRoles.Select(ur => ur.Role.Name).ToList();

            // Yeni token'lar oluştur
            var newAccessToken = _tokenService.GenerateAccessToken(user, roles);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationDays);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new AuthResponseDto
            {
                UserId = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                AccessTokenExpiration = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes),
                RefreshTokenExpiration = user.RefreshTokenExpiryTime.Value,
                Roles = roles
            };
        }

        public async Task<bool> RevokeTokenAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetByRefreshTokenAsync(refreshToken, cancellationToken);

            if (user == null)
                return false;

            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = null;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}


