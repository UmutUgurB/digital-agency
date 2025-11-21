namespace digitalAgency.Application.Wrappers
{
    /// <summary>
    /// Sayfalanmış data için response formatı
    /// GetAll endpoint'lerinde kullanılır
    /// </summary>
    public class PagedResult<T> : Result<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;

        public PagedResult(T data, int pageNumber, int pageSize, int totalRecords)
        {
            Data = data;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            Success = true;
        }

        public static PagedResult<T> Create(T data, int pageNumber, int pageSize, int totalRecords)
        {
            return new PagedResult<T>(data, pageNumber, pageSize, totalRecords);
        }
    }
}

