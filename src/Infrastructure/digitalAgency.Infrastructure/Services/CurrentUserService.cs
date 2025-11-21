using digitalAgency.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace digitalAgency.Infrastructure.Services
{
    /// <summary>
    /// HttpContext'ten şu anki kullanıcının bilgilerine erişim
    /// </summary>
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid? UserId
        {
            get
            {
                var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return Guid.TryParse(userIdClaim, out var userId) ? userId : null;
            }
        }

        public string? Email => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value;

        public string? FullName => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Name)?.Value;

        public IEnumerable<string> Roles
        {
            get
            {
                var user = _httpContextAccessor.HttpContext?.User;
                if (user == null) return Enumerable.Empty<string>();

                return user.FindAll(ClaimTypes.Role).Select(c => c.Value);
            }
        }

        public bool IsAuthenticated => _httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;

        public bool IsInRole(string role)
        {
            return _httpContextAccessor.HttpContext?.User?.IsInRole(role) ?? false;
        }
    }
}


