using digitalAgency.Application.Dtos.Contacts;
using MediatR;

namespace digitalAgency.Application.Features.Contacts.Queries.GetAllContacts
{
    public class GetAllContactsQuery : IRequest<IList<ContactVm>>
    {
    }
}
