using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; } 
        public string ImageUrl { get; set; }    
        
    }
}
