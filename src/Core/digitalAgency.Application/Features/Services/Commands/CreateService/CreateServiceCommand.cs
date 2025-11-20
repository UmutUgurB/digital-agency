using MediatR;

namespace digitalAgency.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
