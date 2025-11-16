namespace digitalAgency.Application.Features.Slider.Commands
{
    public class CreateSliderCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public bool IsShown { get; set; }
        public string ImageUrl { get; set; }
    }
}
