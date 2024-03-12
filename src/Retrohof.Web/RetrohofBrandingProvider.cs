using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Retrohof.Web;

[Dependency(ReplaceServices = true)]
public class RetrohofBrandingProvider : AgileCmsBrandingProvider
{
    public override string AppName => _currentTenant?.Name?.ToLower() ?? "Agile SEO Admin";
    public override string? ShortName => _currentTenant?.Name ?? "Default";

    public RetrohofBrandingProvider(ICurrentTenant currentTenant) : base(currentTenant)
    {
    }
}
