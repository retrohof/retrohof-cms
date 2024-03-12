using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.MainNavbar;

public class MainNavbarViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke(string shortName = "Default")
    {
        return View($"~/Themes/Basic/Components/MainNavbar/{shortName}.cshtml");
    }
}
