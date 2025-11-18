using digitalAgency.Application.Features.Sliders.Commands.CreateSlider;
using digitalAgency.Application.Features.Sliders.Commands.RemoveSlider;
using digitalAgency.Application.Features.Sliders.Commands.UpdateSlider;
using digitalAgency.Application.Features.Sliders.Queries.GetAllSliders;
using digitalAgency.Application.Features.Sliders.Queries.GetSliderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SlidersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllSlidersQuery(), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetSliderByIdQuery { Id = id }, cancellationToken);
            if (result is null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSliderCommand command, CancellationToken cancellationToken)
        {
            var id = await _mediator.Send(command, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, null);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSliderCommand command, CancellationToken cancellationToken)
        {
            command.Id = id;
            await _mediator.Send(command, cancellationToken);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken cancellationToken)
        {
            await _mediator.Send(new RemoveSliderCommand { Id = id }, cancellationToken);
            return NoContent();
        }
    }
}
