using digitalAgency.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(r => r.Name)
                .IsUnique();

            builder.Property(r => r.Description)
                .HasMaxLength(200);

            // Navigation
            builder.HasMany(r => r.UserRoles)
                .WithOne(ur => ur.Role)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Data - Default Roles
            builder.HasData(
                new Role
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Admin",
                    Description = "System Administrator",
                    IsSystemRole = true,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Role
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Editor",
                    Description = "Content Editor",
                    IsSystemRole = true,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false
                },
                new Role
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "User",
                    Description = "Regular User",
                    IsSystemRole = true,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false
                }
            );
        }
    }
}

