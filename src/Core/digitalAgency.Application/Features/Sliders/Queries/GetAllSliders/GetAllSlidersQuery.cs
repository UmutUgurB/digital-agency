using digitalAgency.Application.Dtos.Sliders;
using MediatR;

namespace digitalAgency.Application.Features.Sliders.Queries.GetAllSliders
{
    public class GetAllSlidersQuery : IRequest<IList<SliderVm>>
    {
    }
}
