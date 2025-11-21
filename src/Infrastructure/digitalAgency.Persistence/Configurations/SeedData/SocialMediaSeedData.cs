using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class SocialMediaSeedData
    {
        public static List<SocialMedia> GetSocialMedias()
        {
            return new List<SocialMedia>
            {
                new SocialMedia
                {
                    Id = Guid.Parse("SOC00001-0001-0001-0001-000000000001"),
                    Title = "Facebook",
                    Url = "https://facebook.com/digitalagency",
                    Icon = "fab fa-facebook",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("SOC00001-0001-0001-0001-000000000002"),
                    Title = "Instagram",
                    Url = "https://instagram.com/digitalagency",
                    Icon = "fab fa-instagram",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("SOC00001-0001-0001-0001-000000000003"),
                    Title = "Twitter",
                    Url = "https://twitter.com/digitalagency",
                    Icon = "fab fa-twitter",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("SOC00001-0001-0001-0001-000000000004"),
                    Title = "LinkedIn",
                    Url = "https://linkedin.com/company/digitalagency",
                    Icon = "fab fa-linkedin",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("SOC00001-0001-0001-0001-000000000005"),
                    Title = "YouTube",
                    Url = "https://youtube.com/@digitalagency",
                    Icon = "fab fa-youtube",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

