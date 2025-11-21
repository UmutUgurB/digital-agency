using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<User?> GetByEmailWithRolesAsync(string email, CancellationToken cancellationToken = default);
        Task<User?> GetByIdWithRolesAsync(Guid id, CancellationToken cancellationToken = default);
        Task<User?> GetByRefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default);
        Task<bool> IsEmailExistsAsync(string email, CancellationToken cancellationToken = default);
    }
}


