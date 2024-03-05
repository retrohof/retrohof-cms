using Retrohof.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Retrohof.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class RetrohofPageModel : AbpPageModel
{
    protected RetrohofPageModel()
    {
        LocalizationResourceType = typeof(RetrohofResource);
    }
}
