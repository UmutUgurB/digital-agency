using digitalAgency.Application.Features.Blogs.Commands.CreateBlog;
using digitalAgency.Application.Features.Blogs.Commands.DeleteBlog;
using digitalAgency.Application.Features.Blogs.Commands.UpdateBlog;
using digitalAgency.Application.Features.Blogs.Queries.GetAllBlogs;
using digitalAgency.Application.Features.Blogs.Queries.GetBlogById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Tüm blogları getir (Public - Authorization gerektirmez)
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllBlogsQuery(), cancellationToken);
            return Ok(results);
        }

        /// <summary>
        /// Blog detayını getir (Public - Authorization gerektirmez)
        /// </summary>
        [HttpGet("{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery { Id = id }, cancellationToken);
            return Ok(value);
        }

        /// <summary>
        /// Yeni blog oluştur (Sadece Editor ve Admin)
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Editor,Admin")]
        public async Task<IActionResult> Create(CreateBlogCommand createBlogCommand, CancellationToken ct)
        {
            var id = await _mediator.Send(createBlogCommand, ct);
            return Ok(id);
        }

        /// <summary>
        /// Blog güncelle (Sadece Editor ve Admin)
        /// </summary>
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Editor,Admin")]
        public async Task<IActionResult> Update(Guid id, UpdateBlogCommand updateBlogCommand, CancellationToken ct)
        {
            updateBlogCommand.Id = id;
            await _mediator.Send(updateBlogCommand, ct);
            return NoContent();
        }

        /// <summary>
        /// Blog sil (Sadece Admin)
        /// </summary>
        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken ct)
        {
            await _mediator.Send(new DeleteBlogCommand { Id = id }, ct);
            return NoContent();
        }
    }
}

