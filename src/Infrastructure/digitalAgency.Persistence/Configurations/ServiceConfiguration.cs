using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");

            builder.Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(s => s.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);

            // Seed Data
            builder.HasData(ServiceSeedData.GetServices());
        }
    }
}
