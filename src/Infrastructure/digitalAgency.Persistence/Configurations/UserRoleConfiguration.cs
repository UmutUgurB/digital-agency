using digitalAgency.Domain.Entities;
using digitalAgency.Persistence.Configurations.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace digitalAgency.Persistence.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");

            // Composite key
            builder.HasIndex(ur => new { ur.UserId, ur.RoleId })
                .IsUnique();

            // Seed Data - Assign roles to users
            builder.HasData(
                // Admin user → Admin role
                new UserRole
                {
                    Id = Guid.Parse("AAAA0001-0001-0001-0001-000000000001"),
                    UserId = UserSeedData.AdminUserId,
                    RoleId = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Admin role from RoleConfiguration
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false
                },
                // Editor user → Editor role
                new UserRole
                {
                    Id = Guid.Parse("EEEE0001-0001-0001-0001-000000000001"),
                    UserId = UserSeedData.EditorUserId,
                    RoleId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Editor role from RoleConfiguration
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false
                }
            );
        }
    }
}


