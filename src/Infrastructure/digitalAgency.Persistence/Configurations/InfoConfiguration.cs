using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class InfoConfiguration : IEntityTypeConfiguration<Info>
    {
        public void Configure(EntityTypeBuilder<Info> builder)
        {
            builder.ToTable("Infos");

            builder.Property(i => i.Address)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(i => i.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(i => i.Mail)
                .IsRequired()
                .HasMaxLength(100);

            // Seed Data
            builder.HasData(InfoSeedData.GetInfos());
        }
    }
}
