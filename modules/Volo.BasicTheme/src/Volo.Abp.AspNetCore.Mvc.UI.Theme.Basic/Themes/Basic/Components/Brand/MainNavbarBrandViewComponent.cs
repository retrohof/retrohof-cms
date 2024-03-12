using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Brand;

public class MainNavbarBrandViewComponent : AbpViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public MainNavbarBrandViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual IViewComponentResult Invoke()
    {
        return View($"~/Themes/Basic/Components/Brand/{_brandingProvider.ShortName}.cshtml");
    }
}
