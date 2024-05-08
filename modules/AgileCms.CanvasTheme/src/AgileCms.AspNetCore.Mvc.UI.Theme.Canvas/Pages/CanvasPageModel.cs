using Volo.Abp.AspNetCore.Mvc.UI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CanvasPageModel : AbpPageModel
{
    protected CanvasPageModel()
    {
        LocalizationResourceType = typeof(DefaultResource);
    }
}
