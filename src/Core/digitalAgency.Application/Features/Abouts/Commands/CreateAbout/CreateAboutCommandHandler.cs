using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;

namespace digitalAgency.Application.Features.Abouts.Commands.CreateAbout
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAboutRepository _aboutRepository;

        public CreateAboutCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _aboutRepository = aboutRepository;
        }

        public async Task<Guid> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            var about = _mapper.Map<About>(request);
            await _aboutRepository.AddAsync(about, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return about.Id;
        }
    }
}
