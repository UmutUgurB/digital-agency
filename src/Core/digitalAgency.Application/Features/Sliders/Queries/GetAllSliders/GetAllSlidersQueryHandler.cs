using AutoMapper;
using digitalAgency.Application.Dtos.Sliders;
using digitalAgency.Application.Features.Sliders.Queries.GetAllSliders;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Slidesr.Queries.GetAllSliders
{
    public class GetAllSlidersQueryHandler : IRequestHandler<GetAllSlidersQuery, IList<SliderVm>>
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;

        public GetAllSlidersQueryHandler(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }

        public async Task<IList<SliderVm>> Handle(GetAllSlidersQuery request, CancellationToken cancellationToken)
        {
            var sliders = await _sliderRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<SliderVm>>(sliders);   
        }
    }
}
