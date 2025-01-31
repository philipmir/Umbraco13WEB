using UM13WEBSITE.Models.Search;

namespace UM13WEBSITE.Services;

public interface ISearchService
{
    public SearchResponseModel Search(SearchRequestModel searchRequest);
}