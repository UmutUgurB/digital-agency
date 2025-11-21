using digitalAgency.Application.Dtos.Auth;
using MediatR;

namespace digitalAgency.Application.Features.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommand : IRequest<AuthResponseDto>
    {
        public string RefreshToken { get; set; } = string.Empty;
    }
}


