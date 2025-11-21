using AutoMapper;
using digitalAgency.Application.Dtos.Blogs;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.BlogProfile
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogVm>()
                .ForMember(dest => dest.BlogCategoryName, opt => opt.MapFrom(src => src.BlogCategories.Title))
                .ForMember(dest => dest.TagNames, opt => opt.MapFrom(src => src.Tags.Select(t => t.Title).ToList()));
        }
    }
}

