using digitalAgency.Application.Dtos.Abouts;
using MediatR;

namespace digitalAgency.Application.Features.Abouts.Queries.GetAbout
{
    public class GetAboutQuery : IRequest<IList<AboutVm>>
    {

    }
}
