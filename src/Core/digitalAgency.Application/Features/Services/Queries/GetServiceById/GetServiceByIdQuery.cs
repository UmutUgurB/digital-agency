using digitalAgency.Application.Dtos.Services;
using MediatR;

namespace digitalAgency.Application.Features.Services.Queries.GetServiceById
{
    public class GetServiceByIdQuery : IRequest<ServicesVm>
    { 
    }
}
