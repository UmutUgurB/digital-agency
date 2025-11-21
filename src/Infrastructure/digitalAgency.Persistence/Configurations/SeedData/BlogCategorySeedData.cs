using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class BlogCategorySeedData
    {
        public static List<BlogCategory> GetBlogCategories()
        {
            return new List<BlogCategory>
            {
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000001"),
                    Title = "Dijital Pazarlama",
                    Description = "Dijital pazarlama stratejileri ve güncel trendler hakkında bilgiler",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000002"),
                    Title = "SEO",
                    Description = "Arama motoru optimizasyonu teknikleri ve ipuçları",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000003"),
                    Title = "Sosyal Medya",
                    Description = "Sosyal medya yönetimi ve içerik stratejileri",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000004"),
                    Title = "Web Tasarım",
                    Description = "Modern web tasarım trendleri ve kullanıcı deneyimi",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000005"),
                    Title = "İçerik Pazarlama",
                    Description = "Etkili içerik üretimi ve içerik pazarlama stratejileri",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CA000001-0001-0001-0001-000000000006"),
                    Title = "E-Ticaret",
                    Description = "E-ticaret çözümleri ve online satış stratejileri",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

