using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25.Themes.South25.Components.MainNavbar;

public class MainNavbarViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/South25/Components/MainNavbar/Default.cshtml");
    }
}
