using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.MainNavbar;

public class MainNavbarViewComponent : AbpViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public MainNavbarViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }


    public virtual IViewComponentResult Invoke()
    {
        return View($"~/Themes/Basic/Components/MainNavbar/{_brandingProvider.AppName}.cshtml");
    }
}
