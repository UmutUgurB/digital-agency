using MediatR;

namespace digitalAgency.Application.Features.Abouts.Commands.CreateAbout
{
    public class CreateAboutCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
