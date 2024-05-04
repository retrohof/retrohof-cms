using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.AboutUs;

public class AboutUsViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/AboutUs/Default.cshtml");
    }
}
