using digitalAgency.Application.Dtos.Tags;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Queries.GetTagById
{
    public class GetTagByIdQuery : IRequest<TagVm>
    {
        public Guid Id { get; set; }
    }
}

