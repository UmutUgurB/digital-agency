using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class AboutSeedData
    {
        public static List<About> GetAbouts()
        {
            return new List<About>
            {
                new About
                {
                    Id = Guid.Parse("AB000001-0001-0001-0001-000000000001"),
                    Title = "Hakkımızda - Digital Agency",
                    Description = "2014'ten bu yana dijital pazarlama alanında hizmet veren Digital Agency, 150'den fazla markaya danışmanlık vermiş, 250'den fazla başarılı projeye imza atmıştır. SEO, sosyal medya yönetimi, Google Ads ve web tasarım konularında uzman kadromuzla işletmenizin dijital dünyadaki yolculuğuna rehberlik ediyoruz.",
                    ImageUrl = "https://images.unsplash.com/photo-1522071820081-009f0129c71c?w=800",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false
                }
            };
        }
    }
}

