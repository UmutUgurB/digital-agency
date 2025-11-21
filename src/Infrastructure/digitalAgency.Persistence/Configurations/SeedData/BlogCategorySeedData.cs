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
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000001"),
                    Title = "Dijital Pazarlama",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000002"),
                    Title = "SEO",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000003"),
                    Title = "Sosyal Medya",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000004"),
                    Title = "Web Tasarım",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000005"),
                    Title = "İçerik Pazarlama",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new BlogCategory
                {
                    Id = Guid.Parse("CAT00001-0001-0001-0001-000000000006"),
                    Title = "E-Ticaret",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

