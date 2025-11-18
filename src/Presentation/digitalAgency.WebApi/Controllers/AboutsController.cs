using digitalAgency.Application.Features.Abouts.Commands.CreateAbout;
using digitalAgency.Application.Features.Abouts.Commands.RemoveAbout;
using digitalAgency.Application.Features.Abouts.Queries.GetAbout;
using digitalAgency.Application.Features.Sliders.Commands.CreateSlider;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var result = await _mediator.Send(new GetAboutQuery(),ct);
            return Ok(result);  
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id,CancellationToken ct)
        {
            await _mediator.Send(new RemoveAboutCommand { Id = id }, ct);
            return NoContent(); 
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutCommand command,CancellationToken ct)
        {
            var id = await _mediator.Send(command, ct);
            return Ok("Başarıyla Oluşturuldu");
        }
    }
}
