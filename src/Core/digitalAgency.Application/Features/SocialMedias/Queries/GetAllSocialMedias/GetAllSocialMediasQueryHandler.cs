using AutoMapper;
using digitalAgency.Application.Dtos.SocialMediaDto;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Queries.GetAllSocialMedias
{
    public class GetAllSocialMediasQueryHandler : IRequestHandler<GetAllSocialMediasQuery, IList<SocialMediaVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public GetAllSocialMediasQueryHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<IList<SocialMediaVm>> Handle(GetAllSocialMediasQuery request, CancellationToken cancellationToken)
        {
            var socialMedias = await _socialMediaRepository.GetAllAsync(tracking:false,cancellationToken);
            return _mapper.Map<IList<SocialMediaVm>>(socialMedias);
        }
    }
}
