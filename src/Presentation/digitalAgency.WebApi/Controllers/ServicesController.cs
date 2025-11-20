using AutoMapper;
using digitalAgency.Application.Features.Services.Commands.CreateService;
using digitalAgency.Application.Features.Services.Commands.DeleteService;
using digitalAgency.Application.Features.Services.Commands.UpdateService;
using digitalAgency.Application.Features.Services.Queries.GetAllServices;
using digitalAgency.Application.Features.Services.Queries.GetServiceById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllServicesQuery(), cancellationToken);   
            return Ok(results); 
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken cancellationToken)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery { Id = id }, cancellationToken); 
            return Ok(value);   
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommand createServiceCommand,CancellationToken ct)
        {
            var id = await _mediator.Send(createServiceCommand, ct);
            return Ok("Başarıyla Oluşturuldu");
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateServiceCommand updateServiceCommand,CancellationToken ct)
        {
            updateServiceCommand.Id = id;
            await _mediator.Send(updateServiceCommand, ct);
            return NoContent();
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id,CancellationToken ct)
        {
            await _mediator.Send(new DeleteServiceCommand { Id = id }, ct); 
            return NoContent();
        }
    }
}
