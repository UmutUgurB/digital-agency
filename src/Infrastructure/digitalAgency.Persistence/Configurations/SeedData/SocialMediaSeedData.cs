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
                    Id = Guid.Parse("A0C00001-0001-0001-0001-000000000001"),
                    Title = "Facebook",
                    Url = "https://facebook.com/digitalagency",
                    SocialMediaIcon = "fab fa-facebook",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("A0C00001-0001-0001-0001-000000000002"),
                    Title = "Instagram",
                    Url = "https://instagram.com/digitalagency",
                    SocialMediaIcon = "fab fa-instagram",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("A0C00001-0001-0001-0001-000000000003"),
                    Title = "Twitter",
                    Url = "https://twitter.com/digitalagency",
                    SocialMediaIcon = "fab fa-twitter",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("A0C00001-0001-0001-0001-000000000004"),
                    Title = "LinkedIn",
                    Url = "https://linkedin.com/company/digitalagency",
                    SocialMediaIcon = "fab fa-linkedin",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new SocialMedia
                {
                    Id = Guid.Parse("A0C00001-0001-0001-0001-000000000005"),
                    Title = "YouTube",
                    Url = "https://youtube.com/@digitalagency",
                    SocialMediaIcon = "fab fa-youtube",
                    IsShown = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

