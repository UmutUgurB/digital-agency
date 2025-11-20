using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Contacts.Commands.UpdateContact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateContactCommandHandler(IMapper mapper, IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id, tracking:true,cancellationToken);
            if (contact is null)
                throw new Exception("Mesaj Bulunamadı");
            _mapper.Map(request, contact);  
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return Unit.Value;  
        }
    }
}
