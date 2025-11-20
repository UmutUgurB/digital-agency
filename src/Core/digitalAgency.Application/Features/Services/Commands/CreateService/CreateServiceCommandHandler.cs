using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _serviceRepository;

        public CreateServiceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _serviceRepository = serviceRepository;
        }

        public async Task<Guid> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = _mapper.Map<Service>(request);
            await _serviceRepository.AddAsync(service,cancellationToken); 
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return service.Id;
        }
    }
}
