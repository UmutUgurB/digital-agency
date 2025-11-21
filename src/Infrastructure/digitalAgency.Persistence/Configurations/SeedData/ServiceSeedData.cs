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
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000001"),
                    Title = "SEO Optimizasyonu",
                    Description = "Google'da üst sıralarda yer alın. Organik trafiğinizi artırın ve daha fazla müşteriye ulaşın.",
                    Icon = "🔍",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000002"),
                    Title = "Sosyal Medya Yönetimi",
                    Description = "Instagram, Facebook, LinkedIn ve Twitter'da profesyonel içerik yönetimi ve strateji danışmanlığı.",
                    Icon = "📱",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000003"),
                    Title = "Google Ads Yönetimi",
                    Description = "Hedef kitlenize doğrudan ulaşın. ROI odaklı reklam kampanyaları ile satışlarınızı artırın.",
                    Icon = "🎯",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000004"),
                    Title = "Web Tasarım & Geliştirme",
                    Description = "Modern, hızlı ve kullanıcı dostu web siteleri. Mobil uyumlu ve SEO optimizasyonlu.",
                    Icon = "💻",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000005"),
                    Title = "İçerik Pazarlama",
                    Description = "Blog yazıları, infografikler ve video içerikleri ile markanızı güçlendirin.",
                    Icon = "✍️",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Service
                {
                    Id = Guid.Parse("SRV00001-0001-0001-0001-000000000006"),
                    Title = "E-Ticaret Danışmanlığı",
                    Description = "Online mağazanızı büyütün. Satış hunisi optimizasyonu ve pazaryeri yönetimi.",
                    Icon = "🛒",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

