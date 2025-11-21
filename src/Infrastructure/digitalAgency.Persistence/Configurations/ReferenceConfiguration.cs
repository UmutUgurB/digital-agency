using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class ReferenceConfiguration : IEntityTypeConfiguration<Reference>
    {
        public void Configure(EntityTypeBuilder<Reference> builder)
        {
            builder.ToTable("References");

            builder.Property(r => r.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(r => r.IconUrl)
                .IsRequired()
                .HasMaxLength(500);

            // Seed Data
            builder.HasData(ReferenceSeedData.GetReferences());
        }
    }
}
