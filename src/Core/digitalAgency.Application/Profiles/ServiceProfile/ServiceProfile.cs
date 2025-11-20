using AutoMapper;
using digitalAgency.Application.Dtos.Services;
using digitalAgency.Application.Features.Services.Commands.CreateService;
using digitalAgency.Application.Features.Services.Commands.DeleteService;
using digitalAgency.Application.Features.Services.Commands.UpdateService;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.ServiceProfile
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Service, ServicesVm>().ReverseMap();
            CreateMap<Service,CreateServiceCommand>().ReverseMap();
            CreateMap<Service, DeleteServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();
        }
    }
}
