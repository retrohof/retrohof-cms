using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Themes.Canvas.Components.Footer;

public class FooterViewComponent : AbpViewComponent
{
    public FooterViewComponent()
    {
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("Default.cshtml");
    }
}
