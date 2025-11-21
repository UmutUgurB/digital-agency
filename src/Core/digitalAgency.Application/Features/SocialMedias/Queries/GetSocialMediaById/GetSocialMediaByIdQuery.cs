using digitalAgency.Application.Dtos.SocialMediaDto;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Queries.GetSocialMediaById
{
    public class GetSocialMediaByIdQuery : IRequest<SocialMediaVm>
    {
        public Guid Id { get; set; }    
    }
}
