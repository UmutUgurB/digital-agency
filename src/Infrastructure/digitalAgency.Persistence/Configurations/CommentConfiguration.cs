using digitalAgency.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x=> x.Subject).IsRequired().HasMaxLength(100);   
            builder.Property(x=>x.Content).IsRequired().HasMaxLength(400);
        }
    }
}
