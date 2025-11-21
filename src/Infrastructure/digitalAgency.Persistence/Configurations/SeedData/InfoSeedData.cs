using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class InfoSeedData
    {
        public static List<Info> GetInfos()
        {
            return new List<Info>
            {
                new Info
                {
                    Id = Guid.Parse("INF00001-0001-0001-0001-000000000001"),
                    Address = "Maslak Mahallesi, Büyükdere Caddesi No:123, Sarıyer/İstanbul",
                    Phone = "+90 212 555 1234",
                    Email = "info@digitalagency.com",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

