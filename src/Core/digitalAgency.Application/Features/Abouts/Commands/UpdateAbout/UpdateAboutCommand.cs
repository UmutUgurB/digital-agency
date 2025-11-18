using MediatR;

namespace digitalAgency.Application.Features.Abouts.Commands.UpdateAbout
{
    public class UpdateAboutCommand : IRequest
    {
        public Guid Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
