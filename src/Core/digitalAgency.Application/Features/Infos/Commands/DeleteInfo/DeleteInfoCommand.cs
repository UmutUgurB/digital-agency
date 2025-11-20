using MediatR;

namespace digitalAgency.Application.Features.Infos.Commands.DeleteInfo
{
    public class DeleteInfoCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
