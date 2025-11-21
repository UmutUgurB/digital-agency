using MediatR;

namespace digitalAgency.Application.Features.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

