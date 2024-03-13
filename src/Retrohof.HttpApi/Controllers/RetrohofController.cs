using Volo.Abp.AspNetCore.Mvc;
using DefaultResource = Retrohof.Localization.DefaultResource;

namespace Retrohof.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RetrohofController : AbpControllerBase
{
    protected RetrohofController()
    {
        LocalizationResource = typeof(DefaultResource);
    }
}
