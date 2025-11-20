using AutoMapper;
using digitalAgency.Application.Dtos.References;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.References.Queries.GetAllReferences
{
    public class GetAllReferencesQueryHandler : IRequestHandler<GetAllReferencesQuery, IList<ReferenceVm>>
    {
        private readonly IMapper _mapper;
        private readonly IReferenceRepository _referenceRepository;

        public GetAllReferencesQueryHandler(IMapper mapper, IReferenceRepository referenceRepository)
        {
            _mapper = mapper;
            _referenceRepository = referenceRepository;
        }

        public async Task<IList<ReferenceVm>> Handle(GetAllReferencesQuery request, CancellationToken cancellationToken)
        {
            var references = await _referenceRepository.GetAllAsync(false, cancellationToken);  
            return _mapper.Map<IList<ReferenceVm>>(references); 
        }
    }
}
