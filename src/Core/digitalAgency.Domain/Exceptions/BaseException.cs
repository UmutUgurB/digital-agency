namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Tüm custom exception'ların base sınıfı
    /// </summary>
    public abstract class BaseException : Exception
    {
        public int StatusCode { get; set; }

        protected BaseException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        protected BaseException(string message, int statusCode, Exception innerException) 
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}



