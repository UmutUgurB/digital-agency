using digitalAgency.Application.Dtos.BlogCategories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Queries.GetBlogCategoryById
{
    public class GetBlogCategoryByIdQuery : IRequest<BlogCategoryVm>
    {
        public Guid Id { get; set; }
    }
}

