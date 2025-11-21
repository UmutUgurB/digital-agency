using MediatR;

namespace digitalAgency.Application.Features.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
        public string BlogCategoryName { get; set; }
        public List<string> TagNames { get; set; }
    }
}

