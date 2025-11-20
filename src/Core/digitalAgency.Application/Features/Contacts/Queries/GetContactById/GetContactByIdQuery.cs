using digitalAgency.Application.Dtos.Contacts;
using MediatR;

namespace digitalAgency.Application.Features.Contacts.Queries.GetContactById
{
    public class GetContactByIdQuery : IRequest<ContactVm>
    {
        public Guid Id { get; set; }    
    }
}
