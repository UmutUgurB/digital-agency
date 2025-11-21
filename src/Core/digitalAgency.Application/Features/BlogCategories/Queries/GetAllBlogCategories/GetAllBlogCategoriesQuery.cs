using digitalAgency.Application.Dtos.BlogCategories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Queries.GetAllBlogCategories
{
    public class GetAllBlogCategoriesQuery : IRequest<IList<BlogCategoryVm>>
    {
    }
}

