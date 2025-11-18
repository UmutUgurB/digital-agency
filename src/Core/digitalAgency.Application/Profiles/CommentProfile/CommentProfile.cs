using AutoMapper;
using digitalAgency.Application.Dtos.Comments;
using digitalAgency.Application.Features.Comments.Commands.CreateComment;
using digitalAgency.Application.Features.Comments.Commands.DeleteComment;
using digitalAgency.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace digitalAgency.Application.Profiles.CommentProfile
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentVm>().ReverseMap();
            CreateMap<Comment,CreateCommentCommand>().ReverseMap();
            CreateMap<Comment, DeleteCommentCommand>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommand>().ReverseMap();

        }
    }
}
