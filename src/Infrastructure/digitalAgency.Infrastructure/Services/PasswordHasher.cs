using digitalAgency.Application.Abstractions;
using System.Security.Cryptography;

namespace digitalAgency.Infrastructure.Services
{
    /// <summary>
    /// Password hashing servisi (BCrypt benzeri güvenli hashing)
    /// </summary>
    public class PasswordHasher : IPasswordHasher
    {
        private const int SaltSize = 16; // 128 bits
        private const int KeySize = 32; // 256 bits
        private const int Iterations = 50000;
        private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA256;

        // Format: {iterations}.{salt}.{hash}
        public string HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithm, KeySize);
            
            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            var parts = passwordHash.Split('.');
            if (parts.Length != 3)
                return false;

            var iterations = Convert.ToInt32(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var hash = Convert.FromBase64String(parts[2]);

            var inputHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, _hashAlgorithm, KeySize);

            return CryptographicOperations.FixedTimeEquals(hash, inputHash);
        }
    }
}


