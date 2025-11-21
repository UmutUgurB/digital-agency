using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    /// <summary>
    /// User-Role many-to-many ilişkisi
    /// </summary>
    public class UserRole : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}


