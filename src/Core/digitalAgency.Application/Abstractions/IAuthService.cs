using digitalAgency.Application.Dtos.Auth;

namespace digitalAgency.Application.Abstractions
{
    /// <summary>
    /// Authentication servisi için interface
    /// </summary>
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(string email, string password, CancellationToken cancellationToken = default);
        Task<AuthResponseDto> RegisterAsync(string email, string password, string firstName, string lastName, CancellationToken cancellationToken = default);
        Task<AuthResponseDto> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default);
        Task<bool> RevokeTokenAsync(string refreshToken, CancellationToken cancellationToken = default);
    }
}

