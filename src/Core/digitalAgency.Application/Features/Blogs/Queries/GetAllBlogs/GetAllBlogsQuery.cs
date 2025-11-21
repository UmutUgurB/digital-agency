using digitalAgency.Application.Dtos.Blogs;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Queries.GetAllBlogs
{
    public class GetAllBlogsQuery : IRequest<IList<BlogVm>>
    {
    }
}

