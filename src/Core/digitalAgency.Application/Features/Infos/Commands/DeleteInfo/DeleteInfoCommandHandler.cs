using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Commands.DeleteInfo
{
    public class DeleteInfoCommandHandler : IRequestHandler<DeleteInfoCommand>
    {
        private readonly IInfoRepository _infoRepository;
        private readonly IUnitOfWork    _unitOfWork;

        public DeleteInfoCommandHandler(IInfoRepository infoRepository, IUnitOfWork unitOfWork)
        {
            _infoRepository = infoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteInfoCommand request, CancellationToken cancellationToken)
        {
            var info = await _infoRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (info is null)
                throw new Exception("Bilgilendirme yazısı bulunamadı");
            _infoRepository.Remove(info);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;  
            
        }
    }
}
