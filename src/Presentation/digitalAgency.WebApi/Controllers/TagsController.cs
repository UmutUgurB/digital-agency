using digitalAgency.Application.Features.Tags.Commands.CreateTag;
using digitalAgency.Application.Features.Tags.Commands.DeleteTag;
using digitalAgency.Application.Features.Tags.Commands.UpdateTag;
using digitalAgency.Application.Features.Tags.Queries.GetAllTags;
using digitalAgency.Application.Features.Tags.Queries.GetTagById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllTagsQuery(), cancellationToken);
            return Ok(results);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var value = await _mediator.Send(new GetTagByIdQuery { Id = id }, cancellationToken);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTagCommand createTagCommand, CancellationToken ct)
        {
            var id = await _mediator.Send(createTagCommand, ct);
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateTagCommand updateTagCommand, CancellationToken ct)
        {
            updateTagCommand.Id = id;
            await _mediator.Send(updateTagCommand, ct);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken ct)
        {
            await _mediator.Send(new DeleteTagCommand { Id = id }, ct);
            return NoContent();
        }
    }
}

