using digitalAgency.Application.Dtos.References;
using MediatR;

namespace digitalAgency.Application.Features.References.Queries.GetAllReferences
{
    public class GetAllReferencesQuery : IRequest<IList<ReferenceVm>>
    {
    }
}
