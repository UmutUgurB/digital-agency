using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; } 
        public string Button { get; set; }
        public bool IsShown { get; set; }   
        public string ImageUrl { get; set; }        

    }
}
