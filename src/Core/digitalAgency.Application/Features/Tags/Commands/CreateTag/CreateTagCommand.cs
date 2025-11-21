using MediatR;

namespace digitalAgency.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

