using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;
using System.Runtime.CompilerServices;

namespace digitalAgency.Application.Features.Abouts.Commands.UpdateAbout
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAboutRepository _aboutRepository;

        public UpdateAboutCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _aboutRepository = aboutRepository;
        }

        public async Task<Unit> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var about = await _aboutRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (about is null)
                throw new Exception("Hakkımızda Yazısı Bulunamadı");
            _mapper.Map(request,about);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
