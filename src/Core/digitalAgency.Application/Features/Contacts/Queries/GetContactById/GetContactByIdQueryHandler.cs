using AutoMapper;
using digitalAgency.Application.Dtos.Contacts;
using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Contacts.Queries.GetContactById
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, ContactVm>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public GetContactByIdQueryHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<ContactVm> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _contactRepository.GetByIdAsync(request.Id, false, cancellationToken);
            if (contacts is null)
                return null!;
            return _mapper.Map<ContactVm>(contacts);
        }
    }
}
