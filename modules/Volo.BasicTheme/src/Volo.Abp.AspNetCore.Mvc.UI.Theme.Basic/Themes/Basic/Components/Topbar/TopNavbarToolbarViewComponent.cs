using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Topbar;

public class TopNavbarToolbarViewComponent : AgileCmsViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public TopNavbarToolbarViewComponent(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return GetViewName($"~/Themes/Basic/Components/Topbar/", _brandingProvider.AppName);
    }
}
