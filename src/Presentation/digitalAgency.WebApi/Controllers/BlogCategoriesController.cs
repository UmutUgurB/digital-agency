using digitalAgency.Application.Features.BlogCategories.Commands.CreateBlogCategory;
using digitalAgency.Application.Features.BlogCategories.Commands.DeleteBlogCategory;
using digitalAgency.Application.Features.BlogCategories.Commands.UpdateBlogCategory;
using digitalAgency.Application.Features.BlogCategories.Queries.GetAllBlogCategories;
using digitalAgency.Application.Features.BlogCategories.Queries.GetBlogCategoryById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllBlogCategoriesQuery(), cancellationToken);
            return Ok(results);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var value = await _mediator.Send(new GetBlogCategoryByIdQuery { Id = id }, cancellationToken);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCategoryCommand createBlogCategoryCommand, CancellationToken ct)
        {
            var id = await _mediator.Send(createBlogCategoryCommand, ct);
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateBlogCategoryCommand updateBlogCategoryCommand, CancellationToken ct)
        {
            updateBlogCategoryCommand.Id = id;
            await _mediator.Send(updateBlogCategoryCommand, ct);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id, CancellationToken ct)
        {
            await _mediator.Send(new DeleteBlogCategoryCommand { Id = id }, ct);
            return NoContent();
        }
    }
}

