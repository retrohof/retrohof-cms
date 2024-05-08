using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Brand;

public class MainNavbarBrandViewComponent : AgileCmsViewComponent
{
    public readonly IAgileCmsBrandingProvider _brandingProvider;

    public MainNavbarBrandViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/Brand/", _brandingProvider.AppName);
    }
}
