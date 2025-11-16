using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class BlogCategory : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; } 
        public ICollection<Blog> Blogs { get; set; }    
    }
}
