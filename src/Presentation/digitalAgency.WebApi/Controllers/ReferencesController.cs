using AutoMapper;
using digitalAgency.Application.Features.References.Commands.CreateReference;
using digitalAgency.Application.Features.References.Commands.DeleteReference;
using digitalAgency.Application.Features.References.Commands.UpdateReference;
using digitalAgency.Application.Features.References.Queries.GetAllReferences;
using digitalAgency.Application.Features.References.Queries.GetReferenceById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReferencesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]   
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var results = await _mediator.Send(new GetAllReferencesQuery(),ct);
            return Ok(results); 
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken ct)
        {
            var result = await _mediator.Send(new GetReferenceQuery { Id = id },ct);    
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateReferenceCommand createReferenceCommand,CancellationToken ct)
        {
            var id = await _mediator.Send(createReferenceCommand,ct);   
            return Ok(id);  
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateReferenceCommand updateReferenceCommand,CancellationToken ct)
        {
            updateReferenceCommand.Id = id;
            await _mediator.Send(updateReferenceCommand,ct);    
            return NoContent(); 
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id,CancellationToken cancellationToken)
        {
            await _mediator.Send(new DeleteReferenceCommand { Id = id },cancellationToken);
            return NoContent(); 
        }
    }
}
