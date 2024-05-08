using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Maintenance;

public class MaintenanceViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke(AppInfo appInfo)
    {
        return View("~/Themes/Basic/Components/Maintenance/Default.cshtml", appInfo);
    }
}

public record AppInfo(string Name, string Email);

public static class AppInfoFactory
{
    public static AppInfo Create(string appName)
    {
        switch (appName)
        {
            case "Mdw":
                return new AppInfo("MD Wigmore", "mdwigmore@gmail.com");
            case "ErindOnTrack":
                return new AppInfo("Erind onTrack", "erindontrack@gmail.com");
            case "RetroHof":
                return new AppInfo("RetroHof Ltd", "info@retrohof.co.uk");
            default:
                return new AppInfo("Agile Seo Ltd", "info@agile-seo.com");
        }
    }
}
