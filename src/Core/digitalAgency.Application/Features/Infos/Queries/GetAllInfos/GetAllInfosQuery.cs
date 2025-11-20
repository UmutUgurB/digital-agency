using digitalAgency.Application.Dtos.Infos;
using MediatR;

namespace digitalAgency.Application.Features.Infos.Queries.GetAllInfos
{
    public class GetAllInfosQuery : IRequest<IList<InfoVm>>
    {

    }
}
