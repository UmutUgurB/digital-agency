using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class Reference : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public string IconUrl { get; set; } 
        public bool IsShown { get; set; }   
    }
}
