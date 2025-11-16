
using MediatR;

namespace digitalAgency.Application.Features.Slider.Queries
{
    public class GetSliderListQuery : IRequest<IReadOnlyList<SliderListCommand>>
    {
    }
}
