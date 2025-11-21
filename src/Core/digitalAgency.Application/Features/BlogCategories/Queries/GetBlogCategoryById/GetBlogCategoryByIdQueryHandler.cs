using AutoMapper;
using digitalAgency.Application.Dtos.BlogCategories;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Queries.GetBlogCategoryById
{
    public class GetBlogCategoryByIdQueryHandler : IRequestHandler<GetBlogCategoryByIdQuery, BlogCategoryVm>
    {
        private readonly IBlogCategoryRepository _blogCategoryRepository;
        private readonly IMapper _mapper;

        public GetBlogCategoryByIdQueryHandler(IBlogCategoryRepository blogCategoryRepository, IMapper mapper)
        {
            _blogCategoryRepository = blogCategoryRepository;
            _mapper = mapper;
        }

        public async Task<BlogCategoryVm> Handle(GetBlogCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var blogCategory = await _blogCategoryRepository.GetByIdAsync(request.Id, false, cancellationToken);
            return _mapper.Map<BlogCategoryVm>(blogCategory);
        }
    }
}

