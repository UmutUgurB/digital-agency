using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.References.Commands.UpdateReference
{
    public class UpdateReferenceCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool IsShown { get; set; }
    }
}
