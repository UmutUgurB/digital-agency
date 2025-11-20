using AutoMapper;
using digitalAgency.Application.Dtos.Contacts;
using digitalAgency.Application.Repositories;
using MediatR;
using System.Runtime.CompilerServices;

namespace digitalAgency.Application.Features.Contacts.Queries.GetAllContacts
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQuery, IList<ContactVm>>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public GetAllContactsQueryHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<IList<ContactVm>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _contactRepository.GetAllAsync(false, cancellationToken);
            return _mapper.Map<IList<ContactVm>>(contacts);
        }
    }
}
