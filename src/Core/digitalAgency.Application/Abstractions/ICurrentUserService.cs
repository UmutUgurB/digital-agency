namespace digitalAgency.Application.Abstractions
{
    /// <summary>
    /// Şu anki login olan kullanıcının bilgilerine erişim
    /// </summary>
    public interface ICurrentUserService
    {
        Guid? UserId { get; }
        string? Email { get; }
        string? FullName { get; }
        IEnumerable<string> Roles { get; }
        bool IsAuthenticated { get; }
        bool IsInRole(string role);
    }
}


