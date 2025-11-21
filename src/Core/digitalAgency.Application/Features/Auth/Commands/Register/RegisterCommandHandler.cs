using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Dtos.Auth;
using MediatR;

namespace digitalAgency.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthResponseDto>
    {
        private readonly IAuthService _authService;

        public RegisterCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResponseDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            return await _authService.RegisterAsync(
                request.Email,
                request.Password,
                request.FirstName,
                request.LastName,
                cancellationToken
            );
        }
    }
}

