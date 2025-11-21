namespace digitalAgency.Domain.Exceptions
{
    /// <summary>
    /// Kayıt bulunamadığında fırlatılır
    /// HTTP 404 döndürür
    /// </summary>
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) 
            : base(message, StatusCodes.Status404NotFound)
        {
        }

        public NotFoundException(string entityName, object key)
            : base($"{entityName} with id '{key}' was not found.", StatusCodes.Status404NotFound)
        {
        }
    }

    // StatusCodes için geçici helper (Domain katmanı ASP.NET'e bağımlı olmamalı)
    internal static class StatusCodes
    {
        public const int Status404NotFound = 404;
    }
}






