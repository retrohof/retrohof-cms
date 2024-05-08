using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.MainNavbar;

public class MainNavbarViewComponent : AgileCmsViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public MainNavbarViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/MainNavbar/", _brandingProvider.AppName);
    }
}
