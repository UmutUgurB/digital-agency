using MediatR;

namespace digitalAgency.Application.Features.Infos.Commands.UpdateInfo
{
    public class UpdateInfoCommand : IRequest
    {
        public Guid Id { get; set; }    

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
