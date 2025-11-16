using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class Info : BaseEntity
    {
        public string Address { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Mail { get; set; }    
    }
}
