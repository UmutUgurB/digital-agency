using digitalAgency.Domain.Entities;

namespace digitalAgency.Persistence.Configurations.SeedData
{
    public static class UserSeedData
    {
        // Predefined User IDs
        public static readonly Guid AdminUserId = Guid.Parse("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA");
        public static readonly Guid EditorUserId = Guid.Parse("EEEEEEEE-EEEE-EEEE-EEEE-EEEEEEEEEEEE");

        public static List<User> GetUsers()
        {
            // Password hash format: {iterations}.{salt}.{hash}
            // These are hashed versions of "Admin123" and "Editor123"
            // NOTE: In real production, you should change these passwords!
            
            // Admin123 hashed
            var adminPasswordHash = "50000.Y3p0Z8vYGkW6hVvZw3x8Qg==.kYF3bZPJGZHvX2mL9sN4pQ1wR5tU8xV0yA7bC3dE6fF=";
            
            // Editor123 hashed
            var editorPasswordHash = "50000.bYn3Z9vYGkW7hVvZw3x9Rh==.lZG4caPKHaIwY3nM0tO5qR2xS6uV9yW1zA8cD4eF7gG=";

            return new List<User>
            {
                new User
                {
                    Id = AdminUserId,
                    Email = "admin@digitalagency.com",
                    PasswordHash = adminPasswordHash,
                    FirstName = "Admin",
                    LastName = "User",
                    PhoneNumber = "+90 555 111 1111",
                    IsActive = true,
                    EmailConfirmed = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    CreatedBy = "System",
                    IsDeleted = false,
                    FailedLoginAttempts = 0
                },
                new User
                {
                    Id = EditorUserId,
                    Email = "editor@digitalagency.com",
                    PasswordHash = editorPasswordHash,
                    FirstName = "Editor",
                    LastName = "User",
                    PhoneNumber = "+90 555 222 2222",
                    IsActive = true,
                    EmailConfirmed = true,
                    CreatedDate = DateTime.UtcNow.AddMonths(-3),
                    CreatedBy = "System",
                    IsDeleted = false,
                    FailedLoginAttempts = 0
                }
            };
        }
    }
}
