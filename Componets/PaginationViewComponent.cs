using UM13WEBSITE.Models.Search;
using UM13WEBSITE.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace UM13WEBSITE.Components;

[ViewComponent(Name = "Pagination")]
public class PaginationViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(PaginationViewModel model)
    {
        model ??= new PaginationViewModel();

        return View(model);
    }
}