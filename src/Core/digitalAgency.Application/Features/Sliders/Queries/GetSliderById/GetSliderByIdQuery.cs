using digitalAgency.Application.Dtos.Sliders;
using MediatR;

namespace digitalAgency.Application.Features.Sliders.Queries.GetSliderById
{
    public class GetSliderByIdQuery : IRequest<SliderVm>
    {
        public Guid Id { get; set; }
    }
}
