using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class TagSeedData
    {
        public static List<Tag> GetTags()
        {
            var tagsWithDescriptions = new Dictionary<string, string>
            {
                { "SEO", "Arama motoru optimizasyonu" },
                { "Google Ads", "Google reklam kampanyaları" },
                { "Facebook Ads", "Facebook reklam kampanyaları" },
                { "Instagram", "Instagram pazarlama ve yönetimi" },
                { "LinkedIn", "LinkedIn profesyonel ağ pazarlaması" },
                { "Content Marketing", "İçerik pazarlama stratejileri" },
                { "Email Marketing", "E-posta pazarlama kampanyaları" },
                { "Analytics", "Veri analizi ve raporlama" },
                { "Conversion", "Dönüşüm optimizasyonu" },
                { "UX Design", "Kullanıcı deneyimi tasarımı" },
                { "Mobile Marketing", "Mobil pazarlama stratejileri" },
                { "Video Marketing", "Video içerik pazarlaması" },
                { "Influencer", "Influencer pazarlama kampanyaları" },
                { "E-commerce", "E-ticaret çözümleri" },
                { "Branding", "Marka kimliği ve konumlandırma" }
            };

            var tagList = new List<Tag>();
            int i = 0;
            foreach (var tag in tagsWithDescriptions)
            {
                tagList.Add(new Tag
                {
                    Id = Guid.Parse($"0A600001-0001-0001-0001-{i:D12}"),
                    Title = tag.Key,
                    Description = tag.Value,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                });
                i++;
            }

            return tagList;
        }
    }
}

