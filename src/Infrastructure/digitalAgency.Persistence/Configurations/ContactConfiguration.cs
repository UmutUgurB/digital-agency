using digitalAgency.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x=>x.Subject).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x=>x.Message).IsRequired().HasMaxLength(1000);
        }
    }
}
