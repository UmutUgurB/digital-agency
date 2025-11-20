using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Contexts;

namespace digitalAgency.Persistence.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
