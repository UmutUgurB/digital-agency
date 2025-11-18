using MediatR;

namespace digitalAgency.Application.Features.Comments.Commands.DeleteComment
{
    public class DeleteCommentCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
