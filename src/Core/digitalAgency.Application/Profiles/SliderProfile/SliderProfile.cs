using AutoMapper;
using digitalAgency.Application.Dtos.Sliders;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles
{
    public class SliderProfile : Profile
    {
        public SliderProfile()
        {
            CreateMap<Slider,SliderVm>().ReverseMap();
        }
    }
}
