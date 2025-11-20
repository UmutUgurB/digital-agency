using digitalAgency.Application.Dtos.References;
using MediatR;

namespace digitalAgency.Application.Features.References.Queries.GetReferenceById
{
    public class GetReferenceQuery : IRequest<ReferenceVm>
    {
        public Guid Id { get; set; }    
    }
}
