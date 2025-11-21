namespace digitalAgency.Application.Abstractions
{
    /// <summary>
    /// Password hashing servisi
    /// </summary>
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}


