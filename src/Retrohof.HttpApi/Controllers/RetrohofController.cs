using Retrohof.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Retrohof.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RetrohofController : AbpControllerBase
{
    protected RetrohofController()
    {
        LocalizationResource = typeof(RetrohofResource);
    }
}
