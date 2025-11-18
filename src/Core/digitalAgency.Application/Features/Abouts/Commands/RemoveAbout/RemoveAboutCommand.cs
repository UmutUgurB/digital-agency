using MediatR;

namespace digitalAgency.Application.Features.Abouts.Commands.RemoveAbout
{
    public class RemoveAboutCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
