using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Contacts.Commands.RemoveContact
{
    public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommand>
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveContactCommandHandler(IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id,tracking:true,cancellationToken);
            if (contact is null)
                throw new Exception("Silme İşlemi Başarısız Mesaj Bulunamadı");
            _contactRepository.Remove(contact);
            await _unitOfWork.SaveChangesAsync(cancellationToken);  
            return Unit.Value;
        }
    }
}
