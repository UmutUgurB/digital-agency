using AutoMapper;
using digitalAgency.Application.Dtos.Services;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, IList<ServicesVm>>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public GetAllServicesQueryHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<IList<ServicesVm>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            var result = await _serviceRepository.GetAllAsync(false,cancellationToken);
            return _mapper.Map<IList<ServicesVm>>(result);
            
        }
    }
}
