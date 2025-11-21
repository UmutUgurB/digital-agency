namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Business rule ihlallerinde fırlatılır
    /// HTTP 422 döndürür (Unprocessable Entity)
    /// Örnek: "Bu blog zaten yayında, tekrar yayınlayamazsınız"
    /// </summary>
    public class BusinessException : BaseException
    {
        public BusinessException(string message) 
            : base(message, 422)
        {
        }

        public BusinessException(string message, Exception innerException)
            : base(message, 422, innerException)
        {
        }
    }
}



