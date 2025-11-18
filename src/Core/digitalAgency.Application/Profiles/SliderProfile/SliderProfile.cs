using AutoMapper;
using digitalAgency.Application.Dtos.Sliders;
using digitalAgency.Application.Features.Sliders.Commands.CreateSlider;
using digitalAgency.Application.Features.Sliders.Commands.UpdateSlider;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles
{
    public class SliderProfile : Profile
    {
        public SliderProfile()
        {
            CreateMap<Slider,SliderVm>().ReverseMap();
            CreateMap<CreateSliderCommand, Slider>();
            CreateMap<UpdateSliderCommand,Slider>()
                .ForMember(dest=> dest.Id,opt=>opt.Ignore());
        }
    }
}
