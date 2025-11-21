using AutoMapper;
using digitalAgency.Application.Dtos.Blogs;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Queries.GetAllBlogs
{
    public class GetAllBlogsQueryHandler : IRequestHandler<GetAllBlogsQuery, IList<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetAllBlogsQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<IList<BlogVm>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAllWithIncludesAsync(cancellationToken);
            return _mapper.Map<IList<BlogVm>>(blogs);
        }
    }
}

