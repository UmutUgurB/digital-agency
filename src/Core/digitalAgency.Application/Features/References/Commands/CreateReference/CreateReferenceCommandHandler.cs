using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.References.Commands.CreateReference
{
    public class CreateReferenceCommandHandler : IRequestHandler<CreateReferenceCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReferenceRepository _referenceRepository;

        public CreateReferenceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IReferenceRepository referenceRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _referenceRepository = referenceRepository;
        }

        public async Task<Guid> Handle(CreateReferenceCommand request, CancellationToken cancellationToken)
        {
            var reference =  _mapper.Map<Reference>(request);
            await _referenceRepository.AddAsync(reference,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return reference.Id;
        }
    }
}
