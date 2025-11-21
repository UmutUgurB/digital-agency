using AutoMapper;
using digitalAgency.Application.Dtos.BlogCategories;
using digitalAgency.Application.Features.BlogCategories.Commands.CreateBlogCategory;
using digitalAgency.Application.Features.BlogCategories.Commands.UpdateBlogCategory;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.BlogCategoryProfile
{
    public class BlogCategoryProfile : Profile
    {
        public BlogCategoryProfile()
        {
            CreateMap<BlogCategory, BlogCategoryVm>().ReverseMap();
            CreateMap<BlogCategory, CreateBlogCategoryCommand>().ReverseMap();
            CreateMap<BlogCategory, UpdateBlogCategoryCommand>().ReverseMap();
        }
    }
}

