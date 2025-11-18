using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.RemoveSlider
{
    public class RemoveSliderCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
