using MediatR;

namespace digitalAgency.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

