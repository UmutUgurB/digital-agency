using digitalAgency.Application.Dtos.Blogs;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery : IRequest<BlogVm>
    {
        public Guid Id { get; set; }
    }
}

