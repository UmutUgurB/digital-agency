using digitalAgency.Application.Features.SocialMedias.Commands.CreateSocialMedia;
using digitalAgency.Application.Features.SocialMedias.Commands.DeleteSocialMedia;
using digitalAgency.Application.Features.SocialMedias.Commands.UpdateSocialMedia;
using digitalAgency.Application.Features.SocialMedias.Queries.GetAllSocialMedias;
using digitalAgency.Application.Features.SocialMedias.Queries.GetSocialMediaById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace digitalAgency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllSocialMediasQuery(), cancellationToken);   
            return Ok(results); 
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id,CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetSocialMediaByIdQuery { Id = id }, cancellationToken);  
            return Ok(result);  
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Remove(Guid id,CancellationToken cancellationToken,DeleteSocialMediaCommand deleteSocialMediaCommand)
        {
            var value = await _mediator.Send(new DeleteSocialMediaCommand { Id = id }, cancellationToken);  
            return Ok(value);
        }
        [HttpPost]  
        public async Task<IActionResult> Create(CreateSocialMediaCommand createSocialMediaCommand,CancellationToken cancellationToken)
        {
            var id = await _mediator.Send(createSocialMediaCommand, cancellationToken); 
            return Ok(id);  
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,UpdateSocialMediaCommand updateSocialMediaCommand,CancellationToken cancellationToken)
        {
            updateSocialMediaCommand.Id = id;   
            await _mediator.Send(updateSocialMediaCommand,cancellationToken);   
            return NoContent();
        }

    }
}
