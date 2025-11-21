using digitalAgency.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.Subject)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Message)
                .IsRequired()
                .HasMaxLength(1000);

            // No seed data for contacts - user generated
        }
    }
}
