using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack.Themes.ErindOnTrack.Components.Brand;

public class MainNavbarBrandViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/ErindOnTrack/Components/Brand/Default.cshtml");
    }
}
