using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Features.Sliders.Commands.RemoveSlider;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Abouts.Commands.RemoveAbout
{
    public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommand>    
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveAboutCommandHandler(IAboutRepository aboutRepository, IUnitOfWork unitOfWork)
        {
            _aboutRepository = aboutRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(RemoveAboutCommand request,CancellationToken ct)
        {
            var about = await _aboutRepository.GetByIdAsync(request.Id, tracking:true,ct);
            if (about is null)
                throw new Exception("Hakkımızda Yazısı Bulunamadı");
            _aboutRepository.Remove(about);
            await _unitOfWork.SaveChangesAsync(ct);
            return Unit.Value;
        }
    }
}
