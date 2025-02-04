using UM13WEBSITE.Models.Search;
using UM13WEBSITE.Models.ViewModels;


namespace UM13WEBSITE.Models.ContentModels;

public class SearchPageContentModel(IPublishedContent? content) : ContentModel(content)
{
    public required SearchRequestModel? SearchRequest { get; set; }
    public required SearchResponseModel? SearchResponse { get; set; }
    public required PaginationViewModel Pagination { get; set; }
}