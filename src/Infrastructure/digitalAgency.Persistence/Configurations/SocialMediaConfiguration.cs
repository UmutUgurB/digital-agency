using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.ToTable("SocialMedias");

            builder.Property(sm => sm.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(sm => sm.Url)
                .IsRequired()
                .HasMaxLength(500);

            // Seed Data
            builder.HasData(SocialMediaSeedData.GetSocialMedias());
        }
    }
}

