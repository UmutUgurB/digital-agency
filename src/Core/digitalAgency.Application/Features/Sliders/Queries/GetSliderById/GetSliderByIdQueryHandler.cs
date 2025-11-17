using AutoMapper;
using digitalAgency.Application.Dtos.Sliders;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Slider.Queries.GetSliderById
{
    public class GetSliderByIdQueryHandler : IRequestHandler<GetSliderByIdQuery, SliderVm>
    {
        private readonly ISliderRepository _sliderRepository;   
        private readonly IMapper _mapper;

        public GetSliderByIdQueryHandler(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }

        public async Task<SliderVm> Handle(GetSliderByIdQuery request, CancellationToken cancellationToken)
        {
            var slider = await _sliderRepository.GetByIdAsync(request.Id,false, cancellationToken);
            if (slider is null)
                return null!;
            return _mapper.Map<SliderVm>(slider);   
        }
    }
}
