using AutoMapper;
using digitalAgency.Application.Dtos.Tags;
using digitalAgency.Application.Features.Tags.Commands.CreateTag;
using digitalAgency.Application.Features.Tags.Commands.UpdateTag;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.TagProfile
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagVm>().ReverseMap();
            CreateMap<Tag, CreateTagCommand>().ReverseMap();
            CreateMap<Tag, UpdateTagCommand>().ReverseMap();
        }
    }
}

