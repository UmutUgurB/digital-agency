using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.UpdateSocialMedia
{
    public class UpdateSocialMediaCommand : IRequest
    {
        public Guid Id { get; set; }    
        public string Title { get; set; }
        public string Url { get; set; }
        public string SocialMediaIcon { get; set; }
        public bool IsShown { get; set; }
    }
}
