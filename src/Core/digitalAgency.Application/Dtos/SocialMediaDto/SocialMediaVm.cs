namespace digitalAgency.Application.Dtos.SocialMediaDto
{
    public class SocialMediaVm
    {
        public Guid Id { get; set; }    
        public string Title { get; set; }
        public string Url { get; set; }
        public string SocialMediaIcon { get; set; }
        public bool IsShown { get; set; }
    }
}
