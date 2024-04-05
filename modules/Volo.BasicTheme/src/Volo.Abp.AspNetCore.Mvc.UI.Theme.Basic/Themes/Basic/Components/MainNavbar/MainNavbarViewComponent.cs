using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.MainNavbar;

public class MainNavbarViewComponent : AgileCmsViewComponent
{
    private readonly ICanvasThemeBrandingProvider _brandingProvider;

    public MainNavbarViewComponent(ICanvasThemeBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/MainNavbar/", _brandingProvider.AppName);
    }
}
