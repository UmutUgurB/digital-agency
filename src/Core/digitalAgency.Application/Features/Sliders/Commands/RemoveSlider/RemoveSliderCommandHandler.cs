using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.RemoveSlider
{
    public class RemoveSliderCommandHandler : IRequestHandler<RemoveSliderCommand>
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveSliderCommandHandler(ISliderRepository sliderRepository, IUnitOfWork unitOfWork)
        {
            _sliderRepository = sliderRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(RemoveSliderCommand request, CancellationToken cancellationToken)
        {
            var slider = await _sliderRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (slider is null)
                throw new Exception("Slider not found");

            _sliderRepository.Remove(slider);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
