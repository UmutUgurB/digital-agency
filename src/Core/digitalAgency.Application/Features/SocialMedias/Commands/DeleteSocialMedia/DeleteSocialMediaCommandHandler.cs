using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.SocialMedias.Commands.DeleteSocialMedia
{
    public class DeleteSocialMediaCommandHandler : IRequestHandler<DeleteSocialMediaCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public DeleteSocialMediaCommandHandler(IUnitOfWork unitOfWork, ISocialMediaRepository socialMediaRepository)
        {
            _unitOfWork = unitOfWork;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<Unit> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var socialMedia = await _socialMediaRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (socialMedia is null)
                throw new Exception("We Dont Find Any Social Media");
            _socialMediaRepository.Remove(socialMedia);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
