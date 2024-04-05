using Volo.Abp.MultiTenancy;
using Volo.Abp.Ui.Branding;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

public class CanvasThemeBrandingProvider : DefaultBrandingProvider, ICanvasThemeBrandingProvider
{
    protected readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant?.Name ?? ThemeType.Mdw.ToString();

    public CanvasThemeBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}

public interface ICanvasThemeBrandingProvider : IBrandingProvider
{
    public string? ShortName => ThemeType.Default.ToString();
}
