using AutoMapper;
using digitalAgency.Application.Dtos.References;
using digitalAgency.Application.Features.References.Commands.CreateReference;
using digitalAgency.Application.Features.References.Commands.DeleteReference;
using digitalAgency.Application.Features.References.Commands.UpdateReference;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.ReferenceProfile
{
    public class ReferenceProfile : Profile
    {
        public ReferenceProfile()
        {
            CreateMap<Reference,ReferenceVm>().ReverseMap();    
            CreateMap<Reference,CreateReferenceCommand>().ReverseMap();
            CreateMap<Reference, UpdateReferenceCommand>().ReverseMap();
            CreateMap<Reference, DeleteReferenceCommand>().ReverseMap();

        }
    }
}
