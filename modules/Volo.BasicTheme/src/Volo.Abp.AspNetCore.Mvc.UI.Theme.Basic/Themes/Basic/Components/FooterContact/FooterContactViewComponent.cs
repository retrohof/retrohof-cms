using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.FooterContact;

public class FooterContactViewComponent : ViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/Basic/Components/FooterContact/Default.cshtml");
    }
}
