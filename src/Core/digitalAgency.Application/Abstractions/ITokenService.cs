using digitalAgency.Domain.Entities;
using System.Security.Claims;

namespace digitalAgency.Application.Abstractions
{
    /// <summary>
    /// JWT token generation servisi
    /// </summary>
    public interface ITokenService
    {
        string GenerateAccessToken(User user, IEnumerable<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
    }
}


