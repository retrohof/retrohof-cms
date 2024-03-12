using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Retrohof.Web;

[Dependency(ReplaceServices = true)]
public class RetrohofBrandingProvider : AgileCmsBrandingProvider
{
    private readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant.Name ?? "Agile SEO Admin";
    public string? ShortName => "Default";

    public RetrohofBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}
