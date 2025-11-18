using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.UpdateSlider
{
    public class UpdateSliderCommandHandler : IRequestHandler<UpdateSliderCommand>
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateSliderCommandHandler(ISliderRepository sliderRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateSliderCommand request, CancellationToken cancellationToken)
        {
            var slider = await _sliderRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (slider is null)
                throw new Exception("Slider not found");

            _mapper.Map(request, slider);   
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
