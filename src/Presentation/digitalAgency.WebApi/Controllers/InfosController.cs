using digitalAgency.Application.Features.Infos.Commands.CreateInfo;
using digitalAgency.Application.Features.Infos.Commands.DeleteInfo;
using digitalAgency.Application.Features.Infos.Commands.UpdateInfo;
using digitalAgency.Application.Features.Infos.Queries.GetAllInfos;
using digitalAgency.Application.Features.Infos.Queries.GetInfoById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InfosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]   
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var results = await _mediator.Send(new GetAllInfosQuery(),ct);
            return Ok(results);
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken ct)
        {
            var result = await _mediator.Send(new GetInfoByIdQuery { Id = id },ct);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateInfoCommand createInfoCommand,CancellationToken ct)
        {
            var id = await _mediator.Send(createInfoCommand, ct);   
            return Ok("Başarıyla Oluşturuldu");
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateInfoCommand updateInfoCommand,CancellationToken ct)
        {
            updateInfoCommand.Id = id;
            await _mediator.Send(updateInfoCommand, ct);    
            return NoContent(); 
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(Guid id,CancellationToken ct)
        {
            await _mediator.Send(new DeleteInfoCommand { Id = id },ct); 
            return NoContent(); 
        }


    }
}
