using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;

namespace digitalAgency.Persistence.Repositories
{
    public class BlogCategoryRepository : GenericRepository<BlogCategory>, IBlogCategoryRepository
    {
        public BlogCategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}

