using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.CreateBlogCategory
{
    public class CreateBlogCategoryCommandHandler : IRequestHandler<CreateBlogCategoryCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogCategoryRepository _blogCategoryRepository;

        public CreateBlogCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IBlogCategoryRepository blogCategoryRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _blogCategoryRepository = blogCategoryRepository;
        }

        public async Task<Guid> Handle(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var blogCategory = _mapper.Map<BlogCategory>(request);
            await _blogCategoryRepository.AddAsync(blogCategory, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return blogCategory.Id;
        }
    }
}

