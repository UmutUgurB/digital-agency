using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Domain.Exceptions;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogRepository _blogRepository;
        private readonly IBlogCategoryRepository _blogCategoryRepository;
        private readonly ITagRepository _tagRepository;

        public UpdateBlogCommandHandler(IUnitOfWork unitOfWork, IBlogRepository blogRepository, IBlogCategoryRepository blogCategoryRepository, ITagRepository tagRepository)
        {
            _unitOfWork = unitOfWork;
            _blogRepository = blogRepository;
            _blogCategoryRepository = blogCategoryRepository;
            _tagRepository = tagRepository;
        }

        public async Task<Unit> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdWithIncludesForUpdateAsync(request.Id, cancellationToken);
            if (blog is null)
                throw new NotFoundException(nameof(Blog), request.Id);

            var category = (await _blogCategoryRepository.GetAllAsync(false, cancellationToken))
                .FirstOrDefault(x => x.Title == request.BlogCategoryName);
            if (category is null)
                throw new NotFoundException($"Blog Category with name '{request.BlogCategoryName}' was not found.");

            blog.Title = request.Title;
            blog.Description = request.Description;
            blog.ImageUrl = request.ImageUrl;
            blog.Status = (Domain.Enums.BlogStatus)request.Status;
            blog.BlogCategoryId = category.Id;

            blog.Tags.Clear();
            if (request.TagNames != null && request.TagNames.Any())
            {
                var allTags = await _tagRepository.GetAllAsync(false, cancellationToken);
                var tags = allTags.Where(t => request.TagNames.Contains(t.Title)).ToList();
                foreach (var tag in tags)
                {
                    blog.Tags.Add(tag);
                }
            }

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

