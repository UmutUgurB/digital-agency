using digitalAgency.Domain.Common;

namespace digitalAgency.Application.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
       Task<T?> GetByIdAsync(Guid id, bool tracking = false,CancellationToken cancellationToken=default);
        Task<IList<T>> GetAllAsync(bool tracking = false, CancellationToken cancellationToken = default); Task AddAsync(T entity,CancellationToken cancellationToken=default);
        void Update(T entity);
        void Remove(T entity);

    }
}
