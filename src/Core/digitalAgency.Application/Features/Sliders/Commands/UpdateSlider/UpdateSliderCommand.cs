using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.UpdateSlider
{
    public class UpdateSliderCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public bool IsShown { get; set; }
        public string ImageUrl { get; set; }
    }
}
