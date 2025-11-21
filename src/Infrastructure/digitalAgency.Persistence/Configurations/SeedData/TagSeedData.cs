using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class TagSeedData
    {
        public static List<Tag> GetTags()
        {
            var tags = new[] 
            { 
                "SEO", "Google Ads", "Facebook Ads", "Instagram", "LinkedIn",
                "Content Marketing", "Email Marketing", "Analytics", "Conversion",
                "UX Design", "Mobile Marketing", "Video Marketing", "Influencer",
                "E-commerce", "Branding"
            };

            var tagList = new List<Tag>();
            for (int i = 0; i < tags.Length; i++)
            {
                tagList.Add(new Tag
                {
                    Id = Guid.Parse($"TAG00001-0001-0001-0001-{i:D12}"),
                    Title = tags[i],
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                });
            }

            return tagList;
        }
    }
}

