using MediatR;

namespace digitalAgency.Application.Features.Contacts.Commands.RemoveContact
{
    public class RemoveContactCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
