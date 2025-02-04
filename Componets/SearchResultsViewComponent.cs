using UM13WEBSITE.Models.Search;

using Microsoft.AspNetCore.Mvc;

namespace UM13WEBSITE.Components;

[ViewComponent(Name = "SearchResults")]
public class SearchResultsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(SearchResponseModel model)
    {
        return View(model);
    }
}