namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Validation hatalarında fırlatılır
    /// HTTP 400 döndürür
    /// </summary>
    public class ValidationException : BaseException
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException(string message) 
            : base(message, 400)
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IDictionary<string, string[]> errors)
            : base("One or more validation errors occurred.", 400)
        {
            Errors = errors;
        }

        public ValidationException(string field, string errorMessage)
            : base("Validation error occurred.", 400)
        {
            Errors = new Dictionary<string, string[]>
            {
                { field, new[] { errorMessage } }
            };
        }
    }
}

