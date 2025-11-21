using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class ServiceSeedData
    {
        public static List<Service> GetServices()
        {
            return new List<Service>
            {
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000001"),
                    Title = "SEO Optimizasyonu",
                    Description = "Google'da üst sıralarda yer alın. Organik trafiğinizi artırın ve daha fazla müşteriye ulaşın.",
                    ImageUrl = "https://images.unsplash.com/photo-1571677208715-0ca4e1d2b1b1?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000002"),
                    Title = "Sosyal Medya Yönetimi",
                    Description = "Instagram, Facebook, LinkedIn ve Twitter'da profesyonel içerik yönetimi ve strateji danışmanlığı.",
                    ImageUrl = "https://images.unsplash.com/photo-1611162616305-c69b3fa7fbe0?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000003"),
                    Title = "Google Ads Yönetimi",
                    Description = "Hedef kitlenize doğrudan ulaşın. ROI odaklı reklam kampanyaları ile satışlarınızı artırın.",
                    ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000004"),
                    Title = "Web Tasarım & Geliştirme",
                    Description = "Modern, hızlı ve kullanıcı dostu web siteleri. Mobil uyumlu ve SEO optimizasyonlu.",
                    ImageUrl = "https://images.unsplash.com/photo-1467232004584-a241de8bcf5d?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000005"),
                    Title = "İçerik Pazarlama",
                    Description = "Blog yazıları, infografikler ve video içerikleri ile markanızı güçlendirin.",
                    ImageUrl = "https://images.unsplash.com/photo-1542435503-956c469947f6?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("50000001-0001-0001-0001-000000000006"),
                    Title = "E-Ticaret Danışmanlığı",
                    Description = "Online mağazanızı büyütün. Satış hunisi optimizasyonu ve pazaryeri yönetimi.",
                    ImageUrl = "https://images.unsplash.com/photo-1556742049-0cfed4f6a45d?w=400",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}
