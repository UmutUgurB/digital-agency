using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;

namespace digitalAgency.Persistence.Repositories
{
    public class ReferenceRepository : GenericRepository<Reference>, IReferenceRepository
    {
        public ReferenceRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
