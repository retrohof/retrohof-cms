using System;
using System.Collections.Generic;
using System.Text;
using Retrohof.Localization;
using Volo.Abp.Application.Services;

namespace Retrohof;

/* Inherit your application services from this class.
 */
public abstract class RetrohofAppService : ApplicationService
{
    protected RetrohofAppService()
    {
        LocalizationResource = typeof(RetrohofResource);
    }
}
