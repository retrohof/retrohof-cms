using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Topbar;

public class TopNavbarToolbarViewComponent : AbpViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync(string shortName)
    {
        Check.NotNull(shortName, nameof(shortName));

        return View($"~/Themes/Basic/Components/Topbar/{shortName}.cshtml");
    }
}
