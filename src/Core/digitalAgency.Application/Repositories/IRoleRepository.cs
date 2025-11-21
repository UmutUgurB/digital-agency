using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<List<Role>> GetRolesByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);
    }
}


