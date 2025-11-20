using MediatR;

namespace digitalAgency.Application.Features.Contacts.Commands.CreateContact
{
    public class CreateContactCommand : IRequest<Guid>
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
    }
}
