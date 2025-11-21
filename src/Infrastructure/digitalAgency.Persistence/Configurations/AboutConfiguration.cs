using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable("Abouts");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(x => x.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);

            // Seed Data
            builder.HasData(AboutSeedData.GetAbouts());
        }
    }
}
