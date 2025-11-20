using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;

namespace digitalAgency.Persistence.Repositories
{
    public class InfoRepository : GenericRepository<Info>, IInfoRepository
    {
        public InfoRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
