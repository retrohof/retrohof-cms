using Volo.Abp.MultiTenancy;
using Volo.Abp.Ui.Branding;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

public class AgileCmsBrandingProvider : DefaultBrandingProvider, IAgileCmsBrandingProvider
{
    protected readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant?.Name ?? ThemeType.RetroHof.ToString();

    public AgileCmsBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}

public interface IAgileCmsBrandingProvider : IBrandingProvider
{
    public string? ShortName => ThemeType.Default.ToString();
}
