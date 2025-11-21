using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.UpdateBlogCategory
{
    public class UpdateBlogCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

