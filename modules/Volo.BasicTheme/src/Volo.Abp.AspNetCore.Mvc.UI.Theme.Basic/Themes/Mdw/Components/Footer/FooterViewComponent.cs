using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Mdw.Components.Footer;

public class FooterViewComponent : AbpViewComponent
{
    public FooterViewComponent()
    {
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
		return View("~/Themes/Mdw/Components/Footer/Default.cshtml");
	}
}
