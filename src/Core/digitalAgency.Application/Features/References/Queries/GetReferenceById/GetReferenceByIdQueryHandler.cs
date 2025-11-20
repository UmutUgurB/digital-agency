using AutoMapper;
using digitalAgency.Application.Dtos.References;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.References.Queries.GetReferenceById
{
    public class GetReferenceByIdQueryHandler : IRequestHandler<GetReferenceQuery, ReferenceVm>
    {
        private readonly IMapper _mapper;
        private readonly IReferenceRepository _referenceRepository;

        public GetReferenceByIdQueryHandler(IMapper mapper, IReferenceRepository referenceRepository)
        {
            _mapper = mapper;
            _referenceRepository = referenceRepository;
        }

        public async Task<ReferenceVm> Handle(GetReferenceQuery request, CancellationToken cancellationToken)
        {
            var reference = await _referenceRepository.GetByIdAsync(request.Id,false,cancellationToken);
            if (reference is null)
                return null!;
            return _mapper.Map<ReferenceVm>(reference); 
        }
    }
}
