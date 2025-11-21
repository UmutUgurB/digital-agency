using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITagRepository _tagRepository;

        public DeleteTagCommandHandler(IUnitOfWork unitOfWork, ITagRepository tagRepository)
        {
            _unitOfWork = unitOfWork;
            _tagRepository = tagRepository;
        }

        public async Task<Unit> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (tag is null)
                throw new Exception("Tag Bulunamadı");
            _tagRepository.Remove(tag);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

