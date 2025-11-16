using digitalAgency.Domain.Common;
using digitalAgency.Domain.Enums;

namespace digitalAgency.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; } 
        public string ImageUrl { get; set; }    
        public BlogStatus Status { get; set; }
        public Guid BlogCategoryId { get; set; }    
        public BlogCategory BlogCategories { get; set; } 
        public ICollection<Tag> Tags { get; set; }  
    }
}
