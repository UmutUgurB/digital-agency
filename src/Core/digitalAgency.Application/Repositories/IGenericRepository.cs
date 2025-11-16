using digitalAgency.Domain.Common;

namespace digitalAgency.Application.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
       Task<T?> GetByIdAsync(Guid id,CancellationToken cancellationToken=default, bool tracking = false);
        Task<IList<T>> GetAllAsync(CancellationToken cancellationToken=default,bool tracking =false);
        Task AddAsync(T entity,CancellationToken cancellationToken=default);
        void Update(T entity);
        void Remove(T entity);

    }
}
