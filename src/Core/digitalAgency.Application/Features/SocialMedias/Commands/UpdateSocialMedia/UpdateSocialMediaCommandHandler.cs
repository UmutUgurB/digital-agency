using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateSocialMediaCommandHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var socialMedia = await _socialMediaRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (socialMedia is null)
                throw new Exception("There is no Social Media Account");
            _socialMediaRepository.Update(socialMedia);
            _mapper.Map(request, socialMedia);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
