using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.CreateSocialMedia
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSocialMediaCommandHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var socialMedia = _mapper.Map<SocialMedia>(request);
            await _socialMediaRepository.AddAsync(socialMedia,cancellationToken); 
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return request.Id;
        }
    }
}
