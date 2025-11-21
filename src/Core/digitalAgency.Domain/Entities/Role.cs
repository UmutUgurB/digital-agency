using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    /// <summary>
    /// Rol entity'si (Admin, Editor, Viewer, etc.)
    /// </summary>
    public class Role : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsSystemRole { get; set; } = false; // Sistemsel roller silinemez
        
        // Navigation Properties
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}


