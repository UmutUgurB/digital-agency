using digitalAgency.Application.Dtos.SocialMediaDto;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Queries.GetAllSocialMedias
{
    public class GetAllSocialMediasQuery : IRequest<IList<SocialMediaVm>>
    {
    }
}
