using digitalAgency.Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace digitalAgency.WebApi.Middlewares
{

    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred: {Message}", ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            var response = new ErrorResponse();

            switch (exception)
            {
                case NotFoundException notFoundException:
                    context.Response.StatusCode = notFoundException.StatusCode;
                    response.StatusCode = notFoundException.StatusCode;
                    response.Message = notFoundException.Message;
                    response.Errors = new List<string> { notFoundException.Message };
                    break;

                case ValidationException validationException:
                    context.Response.StatusCode = validationException.StatusCode;
                    response.StatusCode = validationException.StatusCode;
                    response.Message = "Validation errors occurred";
                    response.Errors = validationException.Errors
                        .SelectMany(e => e.Value)
                        .ToList();
                    response.ValidationErrors = validationException.Errors;
                    break;

                case BusinessException businessException:
                    context.Response.StatusCode = businessException.StatusCode;
                    response.StatusCode = businessException.StatusCode;
                    response.Message = businessException.Message;
                    response.Errors = new List<string> { businessException.Message };
                    break;

                case UnauthorizedException unauthorizedException:
                    context.Response.StatusCode = unauthorizedException.StatusCode;
                    response.StatusCode = unauthorizedException.StatusCode;
                    response.Message = unauthorizedException.Message;
                    response.Errors = new List<string> { unauthorizedException.Message };
                    break;

                case AuthenticationException authenticationException:
                    context.Response.StatusCode = authenticationException.StatusCode;
                    response.StatusCode = authenticationException.StatusCode;
                    response.Message = authenticationException.Message;
                    response.Errors = new List<string> { authenticationException.Message };
                    break;

                case ForbiddenException forbiddenException:
                    context.Response.StatusCode = forbiddenException.StatusCode;
                    response.StatusCode = forbiddenException.StatusCode;
                    response.Message = forbiddenException.Message;
                    response.Errors = new List<string> { forbiddenException.Message };
                    break;

                case BaseException baseException:
                    context.Response.StatusCode = baseException.StatusCode;
                    response.StatusCode = baseException.StatusCode;
                    response.Message = baseException.Message;
                    response.Errors = new List<string> { baseException.Message };
                    break;

                default:
                   
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.Message = "An internal server error occurred.";
                    
                    
                    #if DEBUG
                    response.Errors = new List<string> { exception.Message, exception.StackTrace };
                    #else
                    response.Errors = new List<string> { "Please contact support." };
                    #endif
                    break;
            }

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var result = JsonSerializer.Serialize(response, jsonOptions);
            await context.Response.WriteAsync(result);
        }
    }


    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public IDictionary<string, string[]> ValidationErrors { get; set; }
        public DateTime Timestamp { get; set; }

        public ErrorResponse()
        {
            Timestamp = DateTime.UtcNow;
            Errors = new List<string>();
        }
    }

    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}

