using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using digitalAgency.Domain.Exceptions;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogRepository _blogRepository;
        private readonly IBlogCategoryRepository _blogCategoryRepository;
        private readonly ITagRepository _tagRepository;

        public CreateBlogCommandHandler(IUnitOfWork unitOfWork, IBlogRepository blogRepository, IBlogCategoryRepository blogCategoryRepository, ITagRepository tagRepository)
        {
            _unitOfWork = unitOfWork;
            _blogRepository = blogRepository;
            _blogCategoryRepository = blogCategoryRepository;
            _tagRepository = tagRepository;
        }

        public async Task<Guid> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var category = (await _blogCategoryRepository.GetAllAsync(false, cancellationToken))
                .FirstOrDefault(x => x.Title == request.BlogCategoryName);
            if (category is null)
                throw new NotFoundException($"Blog Category with name '{request.BlogCategoryName}' was not found.");

            var blog = new Blog
            {
                Title = request.Title,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Status = (Domain.Enums.BlogStatus)request.Status,
                BlogCategoryId = category.Id,
                Tags = new List<Tag>()
            };

            if (request.TagNames != null && request.TagNames.Any())
            {
                var allTags = await _tagRepository.GetAllAsync(false, cancellationToken);
                var tags = allTags.Where(t => request.TagNames.Contains(t.Title)).ToList();
                foreach (var tag in tags)
                {
                    blog.Tags.Add(tag);
                }
            }

            await _blogRepository.AddAsync(blog, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return blog.Id;
        }
    }
}

