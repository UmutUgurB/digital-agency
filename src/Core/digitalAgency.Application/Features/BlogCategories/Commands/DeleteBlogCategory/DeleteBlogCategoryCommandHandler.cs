using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.BlogCategories.Commands.DeleteBlogCategory
{
    public class DeleteBlogCategoryCommandHandler : IRequestHandler<DeleteBlogCategoryCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogCategoryRepository _blogCategoryRepository;

        public DeleteBlogCategoryCommandHandler(IUnitOfWork unitOfWork, IBlogCategoryRepository blogCategoryRepository)
        {
            _unitOfWork = unitOfWork;
            _blogCategoryRepository = blogCategoryRepository;
        }

        public async Task<Unit> Handle(DeleteBlogCategoryCommand request, CancellationToken cancellationToken)
        {
            var blogCategory = await _blogCategoryRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (blogCategory is null)
                throw new Exception("Blog Kategorisi Bulunamadı");
            _blogCategoryRepository.Remove(blogCategory);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

