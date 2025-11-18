using AutoMapper;
using digitalAgency.Application.Dtos.Abouts;
using digitalAgency.Application.Features.Abouts.Commands.CreateAbout;
using digitalAgency.Application.Features.Abouts.Commands.RemoveAbout;
using digitalAgency.Application.Features.Abouts.Commands.UpdateAbout;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.AboutProfile
{
    public class AboutProfile : Profile
    {
        public AboutProfile()
        {
            CreateMap<About,AboutVm>().ReverseMap();    
            CreateMap<About,CreateAboutCommand>().ReverseMap(); 
            CreateMap<About,RemoveAboutCommand>().ReverseMap(); 
            CreateMap<About,UpdateAboutCommand>().ReverseMap(); 
        }
    }
}
