using AutoMapper;
using digitalAgency.Application.Dtos.Services;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Services.Queries.GetServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, ServicesVm>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public GetServiceByIdQueryHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<ServicesVm> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id,false, cancellationToken);
            if (service is null)
                throw new Exception("Böyle Bir Veri Yok");
            return _mapper.Map<ServicesVm>(service);    
        }
    }
}
