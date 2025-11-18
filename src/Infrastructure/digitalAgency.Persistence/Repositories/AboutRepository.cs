using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;

namespace digitalAgency.Persistence.Repositories
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
