using digitalAgency.Domain.Common;

namespace digitalAgency.Domain.Entities
{
    public class SocialMedia : BaseEntity
    {
        public string Title { get; set; }   
        public string Url { get; set; }
        public string SocialMediaIcon { get; set; } 
        public bool IsShown { get; set; }
    }
}
