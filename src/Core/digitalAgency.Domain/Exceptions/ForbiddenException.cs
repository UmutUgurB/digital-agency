namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Authorization hatalarında fırlatılır (Insufficient permissions)
    /// HTTP 403 döndürür
    /// </summary>
    public class ForbiddenException : BaseException
    {
        public ForbiddenException(string message) 
            : base(message, 403)
        {
        }

        public ForbiddenException(string message, Exception innerException)
            : base(message, 403, innerException)
        {
        }
    }
}

