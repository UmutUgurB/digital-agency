using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.CreateSocialMedia
{
    public class CreateSocialMediaCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string SocialMediaIcon { get; set; }
        public bool IsShown { get; set; }
    }
}
