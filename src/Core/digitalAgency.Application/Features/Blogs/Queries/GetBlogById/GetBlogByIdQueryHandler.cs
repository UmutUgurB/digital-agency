using AutoMapper;
using digitalAgency.Application.Dtos.Blogs;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdWithIncludesAsync(request.Id, cancellationToken);
            return _mapper.Map<BlogVm>(blog);
        }
    }
}

