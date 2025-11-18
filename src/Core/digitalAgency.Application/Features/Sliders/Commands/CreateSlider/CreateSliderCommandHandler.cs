using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.Sliders.Commands.CreateSlider
{
    public class CreateSliderCommandHandler : IRequestHandler<CreateSliderCommand, Guid>
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;

        public CreateSliderCommandHandler(IUnitOfWork unitofwork, ISliderRepository sliderRepository, IMapper mapper)
        {
            _unitofwork = unitofwork;
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateSliderCommand request, CancellationToken cancellationToken)
        {
            var slider = _mapper.Map<Slider>(request);   
            await _sliderRepository.AddAsync(slider, cancellationToken);
            await _unitofwork.SaveChangesAsync(cancellationToken);

            return slider.Id;
        }
    }
}
