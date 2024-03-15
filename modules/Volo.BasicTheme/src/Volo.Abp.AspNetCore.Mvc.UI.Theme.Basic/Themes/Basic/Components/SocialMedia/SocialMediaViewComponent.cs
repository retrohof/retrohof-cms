using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.SocialMedia;

public class SocialMediaViewComponent : ViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/Basic/Components/SocialMedia/Default.cshtml");
    }
}
