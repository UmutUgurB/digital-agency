using AutoMapper;
using digitalAgency.Application.Dtos.Infos;
using digitalAgency.Application.Features.Infos.Commands.CreateInfo;
using digitalAgency.Application.Features.Infos.Commands.DeleteInfo;
using digitalAgency.Application.Features.Infos.Commands.UpdateInfo;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.InfoProfile
{
    public class InfoProfile : Profile
    {
        public InfoProfile()
        {
            
            CreateMap<Info,InfoVm>().ReverseMap();  
            CreateMap<Info,CreateInfoCommand>().ReverseMap();   
            CreateMap<Info,DeleteInfoCommand>().ReverseMap();   
            CreateMap<Info,UpdateInfoCommand>().ReverseMap();   
        }
    }
}
