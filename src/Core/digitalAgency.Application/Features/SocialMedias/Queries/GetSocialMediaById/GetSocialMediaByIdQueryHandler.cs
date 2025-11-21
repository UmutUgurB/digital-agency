using AutoMapper;
using digitalAgency.Application.Dtos.SocialMediaDto;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Queries.GetSocialMediaById
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, SocialMediaVm>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public GetSocialMediaByIdQueryHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<SocialMediaVm> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var socialMedia = await _socialMediaRepository.GetByIdAsync(request.Id, tracking: false, cancellationToken);
            return _mapper.Map<SocialMediaVm>(request);
        }
    }
}
