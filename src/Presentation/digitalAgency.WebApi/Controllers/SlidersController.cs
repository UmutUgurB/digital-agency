using digitalAgency.Application.Features.Slider.Queries.GetAllSliders;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllSlidersQuery(),cancellationToken);   
            return Ok(results); 
        }
    }
}
