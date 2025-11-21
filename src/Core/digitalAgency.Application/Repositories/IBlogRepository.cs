using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Repositories
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Task<IList<Blog>> GetAllWithIncludesAsync(CancellationToken cancellationToken = default);
        Task<Blog?> GetByIdWithIncludesAsync(Guid id, CancellationToken cancellationToken = default);
        Task<Blog?> GetByIdWithIncludesForUpdateAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
