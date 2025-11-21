using digitalAgency.Application.Dtos.Tags;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Queries.GetAllTags
{
    public class GetAllTagsQuery : IRequest<IList<TagVm>>
    {
    }
}

