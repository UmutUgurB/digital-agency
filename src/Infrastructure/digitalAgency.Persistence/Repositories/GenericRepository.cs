using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Common;
using digitalAgency.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace digitalAgency.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
        }

        public async Task<IList<T>> GetAllAsync(CancellationToken cancellationToken = default, bool tracking = false)
        {
            IQueryable<T> query = _dbSet;
            if(!tracking)
                query = query.AsNoTracking();
            return await query.ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default, bool tracking = false)
        {
            IQueryable<T> query = _dbSet;
            if(!tracking)
                query = query.AsNoTracking();   
            return await query.FirstOrDefaultAsync(x=> x.Id == id,cancellationToken); 
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);  
        }
    }
}
