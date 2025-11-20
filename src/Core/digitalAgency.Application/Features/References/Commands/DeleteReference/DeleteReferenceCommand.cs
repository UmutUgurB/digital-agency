using MediatR;

namespace digitalAgency.Application.Features.References.Commands.DeleteReference
{
    public class DeleteReferenceCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
