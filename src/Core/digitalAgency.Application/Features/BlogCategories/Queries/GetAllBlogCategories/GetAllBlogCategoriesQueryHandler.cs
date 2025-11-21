using AutoMapper;
using digitalAgency.Application.Dtos.BlogCategories;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Queries.GetAllBlogCategories
{
    public class GetAllBlogCategoriesQueryHandler : IRequestHandler<GetAllBlogCategoriesQuery, IList<BlogCategoryVm>>
    {
        private readonly IBlogCategoryRepository _blogCategoryRepository;
        private readonly IMapper _mapper;

        public GetAllBlogCategoriesQueryHandler(IBlogCategoryRepository blogCategoryRepository, IMapper mapper)
        {
            _blogCategoryRepository = blogCategoryRepository;
            _mapper = mapper;
        }

        public async Task<IList<BlogCategoryVm>> Handle(GetAllBlogCategoriesQuery request, CancellationToken cancellationToken)
        {
            var blogCategories = await _blogCategoryRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<BlogCategoryVm>>(blogCategories);
        }
    }
}

