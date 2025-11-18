using AutoMapper;
using digitalAgency.Application.Dtos.Abouts;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Abouts.Queries.GetAbout
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, IList<AboutVm>>
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public GetAboutQueryHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<IList<AboutVm>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var about = await _aboutRepository.GetAllAsync(false, cancellationToken);   
            return _mapper.Map<IList<AboutVm>>(about);  
        }
    }
}
