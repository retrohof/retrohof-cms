using Volo.Abp.Application.Services;
using DefaultResource = Retrohof.Localization.DefaultResource;

namespace Retrohof;

/* Inherit your application services from this class.
 */
public abstract class RetrohofAppService : ApplicationService
{
    protected RetrohofAppService()
    {
        LocalizationResource = typeof(DefaultResource);
    }
}
