using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.DeleteSocialMedia
{
    public class DeleteSocialMediaCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
