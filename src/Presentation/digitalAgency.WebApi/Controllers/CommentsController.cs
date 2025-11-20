using digitalAgency.Application.Features.Abouts.Commands.RemoveAbout;
using digitalAgency.Application.Features.Abouts.Commands.UpdateAbout;
using digitalAgency.Application.Features.Comments.Commands.CreateComment;
using digitalAgency.Application.Features.Comments.Commands.DeleteComment;
using digitalAgency.Application.Features.Comments.Commands.UpdateComment;
using digitalAgency.Application.Features.Comments.Queries.GetAllComments;
using digitalAgency.Application.Features.Comments.Queries.GetCommentById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var result = await _mediator.Send(new GetAllCommentsQuery(), ct);
            if(result is null)
                return NotFound();
            return Ok(result);  
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken ct)
        {
            var result = await _mediator.Send(new GetCommentByIdQuery{ Id =id }, ct);
            if (result is null)
                return NotFound();
            return Ok(result);  
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCommentCommand command, CancellationToken ct)
        {
            var id = await _mediator.Send(command, ct);
            return Ok(id);
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateCommentCommand command, CancellationToken ct)
        {
            command.Id = id;
            await _mediator.Send(command,ct);
            return Ok("Güncelleme İşlemi  Başarılı");
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id,CancellationToken ct)
        {
            await _mediator.Send(new DeleteCommentCommand { Id = id }, ct);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
