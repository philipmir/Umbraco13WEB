using UM13WEBSITE.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace UM13WEBSITE.Components;

[ViewComponent(Name = "Contact")]
public class ContactViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ContactViewModel model)
    {
        model ??= new ContactViewModel();

        return View(model);
    }
}