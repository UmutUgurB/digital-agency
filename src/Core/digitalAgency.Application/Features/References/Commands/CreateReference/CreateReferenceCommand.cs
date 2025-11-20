using MediatR;

namespace digitalAgency.Application.Features.References.Commands.CreateReference
{
    public class CreateReferenceCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool IsShown { get; set; }
    }
}
