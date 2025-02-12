namespace kanija_api.DTOs.Common
{
    public class Page
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }

        public Page(int pageIndex, int pageSize, int total)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Total = total;
        }
    }

    public class PagedResponse<T> : ApiResponse<T>
    {
        public Page Page { get; set; }

        public PagedResponse(bool success, string message, T data, List<string> errors = null) : base(success, message, data, errors)
        {
        }
    }
}