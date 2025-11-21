using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.DeleteBlogCategory
{
    public class DeleteBlogCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

