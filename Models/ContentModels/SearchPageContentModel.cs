using UM13WEBSITE.Models.Search;
using UM13WEBSITE.Models.ViewModels;

namespace UM13WEBSITE.Models.ContentModels;

public class SearchPageContentModel(IPublishedContent? content) : ContentModel(content)
{
    public SearchRequestModel? SearchRequest { get; set; }
    public SearchResponseModel? SearchResponse { get; set; }
    public PaginationViewModel Pagination { get; set; }
}