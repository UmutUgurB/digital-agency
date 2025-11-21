using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace digitalAgency.Persistence.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private readonly AppDbContext _context;

        public BlogRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IList<Blog>> GetAllWithIncludesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Blogs
                .Include(b => b.BlogCategories)
                .Include(b => b.Tags)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Blog?> GetByIdWithIncludesAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Blogs
                .Include(b => b.BlogCategories)
                .Include(b => b.Tags)
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
        }

        public async Task<Blog?> GetByIdWithIncludesForUpdateAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Blogs
                .Include(b => b.Tags)
                .FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
        }
    }
}

