using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITagRepository _tagRepository;

        public UpdateTagCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, ITagRepository tagRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _tagRepository = tagRepository;
        }

        public async Task<Unit> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _tagRepository.GetByIdAsync(request.Id, tracking: true, cancellationToken);
            if (tag is null)
                throw new Exception("Tag Bulunamadı");
            _mapper.Map(request, tag);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

