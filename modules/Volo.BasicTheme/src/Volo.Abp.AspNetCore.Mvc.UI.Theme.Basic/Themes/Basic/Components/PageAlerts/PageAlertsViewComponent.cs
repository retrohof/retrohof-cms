using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;
using Volo.Abp.Ui.Branding;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.PageAlerts;

public class PageAlertsViewComponent : AgileCmsViewComponent
{
    private readonly IBrandingProvider _brandingProvider;

    protected IAlertManager AlertManager { get; }

    public PageAlertsViewComponent(IAlertManager alertManager, ICanvasThemeBrandingProvider brandingProvider)
    {
        AlertManager = alertManager;
        _brandingProvider = brandingProvider;
    }

    public IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/PageAlerts/", _brandingProvider.AppName, AlertManager.Alerts);
    }
}
