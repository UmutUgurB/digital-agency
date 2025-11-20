using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;
using System.IO.IsolatedStorage;

namespace digitalAgency.Application.Features.Infos.Commands.UpdateInfo
{
    public class UpdateInfoCommandHandler : IRequestHandler<UpdateInfoCommand>  
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IInfoRepository _infoRepository;
        private readonly IMapper _mapper;

        public UpdateInfoCommandHandler(IUnitOfWork unitOfWork, IInfoRepository infoRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _infoRepository = infoRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateInfoCommand request, CancellationToken cancellationToken)
        {
            var info = await _infoRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (info is null)
                throw new Exception("Bilgilendirme Bulunamadı");
            _mapper.Map(request,info);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
