using FluentValidation;
using MediatR;
using ValidationException = digitalAgency.Domain.Exceptions.ValidationException;

namespace digitalAgency.Application.Behaviors
{
    /// <summary>
    /// MediatR Pipeline Behavior
    /// Her request için otomatik validation yapar
    /// Request -> ValidationBehavior -> Handler -> Response
    /// </summary>
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            // Eğer validator yoksa direkt devam et
            if (!_validators.Any())
            {
                return await next();
            }

            // Validation context oluştur
            var context = new ValidationContext<TRequest>(request);

            // Tüm validator'ları çalıştır
            var validationResults = await Task.WhenAll(
                _validators.Select(v => v.ValidateAsync(context, cancellationToken))
            );

            // Hataları topla
            var failures = validationResults
                .Where(r => !r.IsValid)
                .SelectMany(r => r.Errors)
                .ToList();

            // Eğer hata varsa ValidationException fırlat
            if (failures.Any())
            {
                var errors = failures
                    .GroupBy(e => e.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(e => e.ErrorMessage).ToArray()
                    );

                throw new ValidationException(errors);
            }

            // Validation başarılı, handler'a devam et
            return await next();
        }
    }
}

