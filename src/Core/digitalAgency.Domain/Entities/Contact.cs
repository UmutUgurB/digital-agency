using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{ 
    public class Contact :BaseEntity
    {
        public string Email { get; set; }   
        public string Phone { get; set; }   
        public string Subject { get; set; } 
        public string Message { get; set; } 
        public bool IsActive { get; set; }  
    }
}
