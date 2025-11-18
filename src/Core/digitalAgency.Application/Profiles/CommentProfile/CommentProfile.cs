using AutoMapper;
using digitalAgency.Application.Dtos.Comments;
using digitalAgency.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace digitalAgency.Application.Profiles.CommentProfile
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment,CommentVm>().ReverseMap();    

        }
    }
}
