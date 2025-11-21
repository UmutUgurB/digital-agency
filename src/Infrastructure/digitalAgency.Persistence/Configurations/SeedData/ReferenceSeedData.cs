using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class ReferenceSeedData
    {
        public static List<Reference> GetReferences()
        {
            return new List<Reference>
            {
                new Reference
                {
                    Id = Guid.Parse("0EF00001-0001-0001-0001-000000000001"),
                    Title = "TechCorp A.Ş.",
                    Description = "SEO ve içerik pazarlama projesi",
                    IconUrl = "https://via.placeholder.com/300x200?text=TechCorp",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-5),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Reference
                {
                    Id = Guid.Parse("0EF00001-0001-0001-0001-000000000002"),
                    Title = "FashionBrand",
                    Description = "Sosyal medya yönetimi ve influencer marketing",
                    IconUrl = "https://via.placeholder.com/300x200?text=Fashion",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-4),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Reference
                {
                    Id = Guid.Parse("0EF00001-0001-0001-0001-000000000003"),
                    Title = "E-Commerce Plus",
                    Description = "Google Ads ve e-ticaret optimizasyonu",
                    IconUrl = "https://via.placeholder.com/300x200?text=ECommerce",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-3),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Reference
                {
                    Id = Guid.Parse("0EF00001-0001-0001-0001-000000000004"),
                    Title = "HealthCare Solutions",
                    Description = "Web tasarım ve dijital pazarlama stratejisi",
                    IconUrl = "https://via.placeholder.com/300x200?text=Healthcare",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Reference
                {
                    Id = Guid.Parse("0EF00001-0001-0001-0001-000000000005"),
                    Title = "RestaurantChain",
                    Description = "Yerel SEO ve sosyal medya kampanyaları",
                    IconUrl = "https://via.placeholder.com/300x200?text=Restaurant",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-1),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}
