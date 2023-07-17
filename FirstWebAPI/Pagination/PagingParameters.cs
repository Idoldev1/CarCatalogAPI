namespace FirstWebAPI.Pagination;

public class PagingParameters
{
    const int maxPageSize = 15;
    public int PageNumber { get; set; } = 1;
    private int _pagesize = 10;
    public int PageSize {
        get
        {
            return _pagesize;
        }
        set
        {
            _pagesize=(value > maxPageSize) ? maxPageSize : value;
        }
    }
}