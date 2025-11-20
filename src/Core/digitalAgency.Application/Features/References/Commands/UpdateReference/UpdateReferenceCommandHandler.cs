using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.References.Commands.UpdateReference
{
    
    public class UpdateReferenceCommandHandler : IRequestHandler<UpdateReferenceCommand>
    {
        private readonly IReferenceRepository _referenceRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateReferenceCommandHandler(IReferenceRepository referenceRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReferenceCommand request, CancellationToken cancellationToken)
        {
            var reference = await _referenceRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (reference == null)
                throw new Exception("Referens Bulunamadı");
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;  
            
        }
    }
}
