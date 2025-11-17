namespace digitalAgency.Application.Dtos.Sliders
{
    public class SliderVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public bool IsShown { get; set; }
        public string ImageUrl { get; set; }
    }
}
