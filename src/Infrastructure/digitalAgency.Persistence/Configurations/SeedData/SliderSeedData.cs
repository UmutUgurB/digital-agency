using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class SliderSeedData
    {
        public static List<Slider> GetSliders()
        {
            return new List<Slider>
            {
                new Slider
                {
                    Id = Guid.Parse("51D00001-0001-0001-0001-000000000001"),
                    Title = "Dijital Pazarlama ile İşinizi Büyütün",
                    Description = "Profesyonel dijital pazarlama stratejileri ile markanızı zirveye taşıyın",
                    Button = "Hemen Başla",
                    ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=1200",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-5),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Slider
                {
                    Id = Guid.Parse("51D00001-0001-0001-0001-000000000002"),
                    Title = "SEO ile Organik Trafiğinizi Artırın",
                    Description = "Google'ın ilk sayfasında yer alın",
                    Button = "Detaylı Bilgi",
                    ImageUrl = "https://images.unsplash.com/photo-1432888622747-4eb9a8f2c1e?w=1200",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-4),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Slider
                {
                    Id = Guid.Parse("51D00001-0001-0001-0001-000000000003"),
                    Title = "Sosyal Medyada Fark Yaratın",
                    Description = "Hedef kitlenize ulaşın",
                    Button = "İletişime Geç",
                    ImageUrl = "https://images.unsplash.com/photo-1611162617474-5b21e879e113?w=1200",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-3),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}
