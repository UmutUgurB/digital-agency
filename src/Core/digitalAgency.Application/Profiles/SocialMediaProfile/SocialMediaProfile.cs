using AutoMapper;
using digitalAgency.Application.Dtos.SocialMediaDto;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.SocialMediaProfile
{
    public class SocialMediaProfile : Profile
    {
        public SocialMediaProfile()
        {
            CreateMap<SocialMedia,SocialMediaVm>().ReverseMap();
        }
    }
}
