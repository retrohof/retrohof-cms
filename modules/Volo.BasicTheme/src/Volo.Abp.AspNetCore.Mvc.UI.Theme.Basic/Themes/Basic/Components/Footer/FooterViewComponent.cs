using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Footer;
public class FooterViewComponent : ViewComponent
{
	//private readonly IDefaultFooterProvider _defaultFooterProvider;

	//public FooterViewComponent(IDefaultFooterProvider defaultFooterProvider)
 //   {
	//	_defaultFooterProvider = defaultFooterProvider;
	//}

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/Basic/Components/Footer/Default.cshtml", new DefaultFooterProvider());
    }
}
