using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.CreateBlogCategory
{
    public class CreateBlogCategoryCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

