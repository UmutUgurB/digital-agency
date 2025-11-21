using digitalAgency.Application.Features.Blogs.Commands.CreateBlog;
using digitalAgency.Application.Features.Blogs.Commands.DeleteBlog;
using digitalAgency.Application.Features.Blogs.Commands.UpdateBlog;
using digitalAgency.Application.Features.Blogs.Queries.GetAllBlogs;
using digitalAgency.Application.Features.Blogs.Queries.GetBlogById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllBlogsQuery(), cancellationToken);
            return Ok(results);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery { Id = id }, cancellationToken);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCommand createBlogCommand, CancellationToken ct)
        {
            var id = await _mediator.Send(createBlogCommand, ct);
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateBlogCommand updateBlogCommand, CancellationToken ct)
        {
            updateBlogCommand.Id = id;
            await _mediator.Send(updateBlogCommand, ct);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken ct)
        {
            await _mediator.Send(new DeleteBlogCommand { Id = id }, ct);
            return NoContent();
        }
    }
}

