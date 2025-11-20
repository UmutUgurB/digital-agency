using AutoMapper;
using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Domain.Entities;
using MediatR;
using System.Runtime.CompilerServices;

namespace digitalAgency.Application.Features.Contacts.Commands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Guid>
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IContactRepository contactRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = _mapper.Map<Contact>(request);    
            await _contactRepository.AddAsync(contact, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contact.Id;  
        }
    }
}
