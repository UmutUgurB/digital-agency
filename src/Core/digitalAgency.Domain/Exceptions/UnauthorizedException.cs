namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Yetkisiz erişim denemelerinde fırlatılır
    /// HTTP 401 döndürür
    /// </summary>
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message = "Unauthorized access.") 
            : base(message, 401)
        {
        }
    }
}






