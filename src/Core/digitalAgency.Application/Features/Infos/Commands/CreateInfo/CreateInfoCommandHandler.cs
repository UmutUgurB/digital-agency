using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Commands.CreateInfo
{
    public class CreateInfoCommandHandler : IRequestHandler<CreateInfoCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IInfoRepository _infoRepository;

        public CreateInfoCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IInfoRepository infoRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _infoRepository = infoRepository;
        }

        public async Task<Guid> Handle(CreateInfoCommand request, CancellationToken cancellationToken)
        {
            var info = _mapper.Map<Info>(request);  
            await _infoRepository.AddAsync(info,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return info.Id; 
        }
    }
}
