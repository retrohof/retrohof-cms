using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Newsletter;

public class NewsLetterViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/NewsLetter/Default.cshtml");
    }
}
