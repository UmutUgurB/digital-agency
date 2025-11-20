using MediatR;

namespace digitalAgency.Application.Features.Infos.Commands.CreateInfo
{
    public class CreateInfoCommand : IRequest<Guid>
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
