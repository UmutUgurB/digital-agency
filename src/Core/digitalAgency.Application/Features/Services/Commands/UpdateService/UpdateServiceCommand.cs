using MediatR;

namespace digitalAgency.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
