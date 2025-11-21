using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlogRepository _blogRepository;

        public DeleteBlogCommandHandler(IUnitOfWork unitOfWork, IBlogRepository blogRepository)
        {
            _unitOfWork = unitOfWork;
            _blogRepository = blogRepository;
        }

        public async Task<Unit> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (blog is null)
                throw new Exception("Blog Bulunamadı");
            _blogRepository.Remove(blog);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

