using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.CreateSlider
{
    public class CreateSliderCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public bool IsShown { get; set; }
        public string ImageUrl { get; set; }
    }
}
