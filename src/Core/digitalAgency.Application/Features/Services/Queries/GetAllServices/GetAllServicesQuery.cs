using digitalAgency.Application.Dtos.Services;
using MediatR;

namespace digitalAgency.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQuery : IRequest<IList<ServicesVm>>
    {
    }
}
