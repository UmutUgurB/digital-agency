using digitalAgency.Application.Dtos.Comments;
using MediatR;

namespace digitalAgency.Application.Features.Comments.Queries.GetAllComments
{
    public class GetAllCommentsQuery : IRequest<IList<CommentVm>>
    {
    }
}
