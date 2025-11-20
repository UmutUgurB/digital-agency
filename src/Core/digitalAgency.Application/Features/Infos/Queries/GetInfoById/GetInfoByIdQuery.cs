using digitalAgency.Application.Dtos.Infos;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Queries.GetInfoById
{
    public class GetInfoByIdQuery : IRequest<InfoVm>
    {
        public Guid Id { get; set; }    
    }
}
