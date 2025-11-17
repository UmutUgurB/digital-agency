using digitalAgency.Application.Dtos.Sliders;
using MediatR;

namespace digitalAgency.Application.Features.Slider.Queries.GetAllSliders
{
    public class GetAllSlidersQuery : IRequest<IList<SliderVm>>
    {
    }
}
