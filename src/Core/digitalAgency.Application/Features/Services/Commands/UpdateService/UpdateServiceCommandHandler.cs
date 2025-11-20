using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _serviceRepository;

        public UpdateServiceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            _mapper.Map(request, service);  
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return Unit.Value;  
        }
    }
}
