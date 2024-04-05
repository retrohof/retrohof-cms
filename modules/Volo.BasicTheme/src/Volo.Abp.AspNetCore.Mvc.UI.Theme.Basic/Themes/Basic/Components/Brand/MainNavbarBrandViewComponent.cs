using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Brand;

public class MainNavbarBrandViewComponent : AgileCmsViewComponent
{
    public readonly ICanvasThemeBrandingProvider _brandingProvider;

    public MainNavbarBrandViewComponent(ICanvasThemeBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/Brand/", _brandingProvider.AppName);
    }
}
