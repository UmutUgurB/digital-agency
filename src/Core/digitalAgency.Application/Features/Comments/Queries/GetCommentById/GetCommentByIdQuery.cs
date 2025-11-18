using AutoMapper;
using digitalAgency.Application.Dtos.Comments;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Comments.Queries.GetCommentById
{
    public class GetCommentByIdQuery : IRequest<CommentVm>
    {
        public Guid Id { get; set; }    

    }
}
