using MediatR;

namespace digitalAgency.Application.Features.Comments.Commands.UpdateComment
{
    public class UpdateCommentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsShown { get; set; }
    }
}
