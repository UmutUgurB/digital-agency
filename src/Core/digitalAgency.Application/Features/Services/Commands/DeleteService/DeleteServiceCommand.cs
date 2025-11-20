using digitalAgency.Application.Repositories;
using MediatR;

namespace digitalAgency.Application.Features.Services.Commands.DeleteService
{
    public class DeleteServiceCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
