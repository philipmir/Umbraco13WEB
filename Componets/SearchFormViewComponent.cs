using UM13WEBSITE.Models.Search;

using Microsoft.AspNetCore.Mvc;

namespace UM13WEBSITE.Components;

[ViewComponent(Name = "SearchForm")]
public class SearchFormViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(SearchRequestModel model)
    {
        return View(model);
    }
}