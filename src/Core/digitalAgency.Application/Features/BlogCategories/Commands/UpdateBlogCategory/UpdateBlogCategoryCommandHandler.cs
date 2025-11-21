using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.UpdateBlogCategory
{
    public class UpdateBlogCategoryCommandHandler : IRequestHandler<UpdateBlogCategoryCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogCategoryRepository _blogCategoryRepository;

        public UpdateBlogCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IBlogCategoryRepository blogCategoryRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _blogCategoryRepository = blogCategoryRepository;
        }

        public async Task<Unit> Handle(UpdateBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var blogCategory = await _blogCategoryRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (blogCategory is null)
                throw new Exception("Blog Kategorisi Bulunamadı");
            _mapper.Map(request, blogCategory);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

