using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class Comment :BaseEntity
    {
        public string Subject { get; set; } 
        public string Content { get; set; } 
        public bool IsShown { get; set; }   
    }
}
