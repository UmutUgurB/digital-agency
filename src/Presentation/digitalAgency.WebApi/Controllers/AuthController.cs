using digitalAgency.Application.Features.Auth.Commands.Login;
using digitalAgency.Application.Features.Auth.Commands.RefreshToken;
using digitalAgency.Application.Features.Auth.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace digitalAgency.WebApi.Controllers
{
    /// <summary>
    /// Authentication Controller
    /// Login, Register, Refresh Token endpoints
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Kullanıcı girişi (Login)
        /// </summary>
        /// <param name="command">Email ve şifre</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Access token, refresh token ve kullanıcı bilgileri</returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginCommand command, CancellationToken ct)
        {
            var result = await _mediator.Send(command, ct);
            return Ok(result);
        }

        /// <summary>
        /// Yeni kullanıcı kaydı (Register)
        /// </summary>
        /// <param name="command">Kullanıcı bilgileri</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Access token, refresh token ve kullanıcı bilgileri</returns>
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterCommand command, CancellationToken ct)
        {
            var result = await _mediator.Send(command, ct);
            return Ok(result);
        }

        /// <summary>
        /// Refresh token ile yeni access token alma
        /// </summary>
        /// <param name="command">Refresh token</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Yeni access token ve refresh token</returns>
        [HttpPost("refresh-token")]
        [AllowAnonymous]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenCommand command, CancellationToken ct)
        {
            var result = await _mediator.Send(command, ct);
            return Ok(result);
        }

        /// <summary>
        /// Test endpoint - Authentication kontrolü
        /// </summary>
        [HttpGet("me")]
        [Authorize]
        public IActionResult GetCurrentUser()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var email = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;
            var roles = User.FindAll(System.Security.Claims.ClaimTypes.Role).Select(c => c.Value);

            return Ok(new
            {
                UserId = userId,
                Email = email,
                Roles = roles,
                IsAuthenticated = User.Identity?.IsAuthenticated ?? false
            });
        }

        /// <summary>
        /// Test endpoint - Admin rolü kontrolü
        /// </summary>
        [HttpGet("admin-only")]
        [Authorize(Roles = "Admin")]
        public IActionResult AdminOnly()
        {
            return Ok(new { Message = "Bu endpoint sadece Admin rolüne açık!" });
        }
    }
}

