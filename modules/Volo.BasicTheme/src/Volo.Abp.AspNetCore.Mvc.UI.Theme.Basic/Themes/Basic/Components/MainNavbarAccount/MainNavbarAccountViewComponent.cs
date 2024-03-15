using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.MainNavbar;

public class MainNavbarAccountViewComponent : AgileCmsViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public MainNavbarAccountViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/MainNavbarAccount/", _brandingProvider.AppName);
    }
}
