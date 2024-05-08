using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Retrohof.Web;

[Dependency(ReplaceServices = true)]
public class RetrohofBrandingProvider : DefaultBrandingProvider
{
    private readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant.Name ?? "Admin";

    public RetrohofBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}