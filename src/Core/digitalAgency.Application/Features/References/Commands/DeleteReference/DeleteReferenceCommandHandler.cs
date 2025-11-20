using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.References.Commands.DeleteReference
{
    public class DeleteReferenceCommandHandler : IRequestHandler<DeleteReferenceCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReferenceRepository _referenceRepository;

        public DeleteReferenceCommandHandler(IUnitOfWork unitOfWork, IReferenceRepository referenceRepository)
        {
            _unitOfWork = unitOfWork;
            _referenceRepository = referenceRepository;
        }

        public async Task<Unit> Handle(DeleteReferenceCommand request, CancellationToken cancellationToken)
        {
            var reference = await _referenceRepository.GetByIdAsync(request.Id, tracking: true,cancellationToken);
            if (reference == null)
                throw new Exception("Referans Bulunamadı");
            _referenceRepository.Remove(reference);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
