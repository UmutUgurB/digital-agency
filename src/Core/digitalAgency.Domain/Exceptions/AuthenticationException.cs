namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Authentication hatalarında fırlatılır (Invalid credentials, etc.)
    /// HTTP 401 döndürür
    /// </summary>
    public class AuthenticationException : BaseException
    {
        public AuthenticationException(string message) 
            : base(message, 401)
        {
        }

        public AuthenticationException(string message, Exception innerException)
            : base(message, 401, innerException)
        {
        }
    }
}


