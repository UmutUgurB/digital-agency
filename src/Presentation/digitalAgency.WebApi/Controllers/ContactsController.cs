using digitalAgency.Application.Features.Contacts.Commands.CreateContact;
using digitalAgency.Application.Features.Contacts.Commands.RemoveContact;
using digitalAgency.Application.Features.Contacts.Commands.UpdateContact;
using digitalAgency.Application.Features.Contacts.Queries.GetAllContacts;
using digitalAgency.Application.Features.Contacts.Queries.GetContactById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct )
        {
            var result = await _mediator.Send(new GetAllContactsQuery(),ct);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateContactCommand createContactCommand, CancellationToken ct)
        {
            var id = await _mediator.Send(createContactCommand, ct);    
            return Ok(id);
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateContactCommand updateContactCommand, CancellationToken ct)
        {
            updateContactCommand.Id = id;
            await _mediator.Send(updateContactCommand, ct); 
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken ct)
        {
            var result = await _mediator.Send(new GetContactByIdQuery { Id = id },ct);    
            return Ok(result);  
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken ct)
        {
            await _mediator.Send(new RemoveContactCommand { Id = id },ct);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
