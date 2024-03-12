using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Retrohof.Web;

[Dependency(ReplaceServices = true)]
public class RetrohofBrandingProvider : AgileCmsBrandingProvider
{
    public override string AppName => _currentTenant?.Name?.ToLower() ?? "Default";

    public RetrohofBrandingProvider(ICurrentTenant currentTenant) : base(currentTenant)
    {
    }
}
