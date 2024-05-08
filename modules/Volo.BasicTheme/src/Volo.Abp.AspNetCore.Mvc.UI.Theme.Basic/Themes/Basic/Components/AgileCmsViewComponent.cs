using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components;

public abstract class AgileCmsViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult GetViewName(string path, string appName)
    {
        var view = appName == ThemeType.Default.ToString() ? "Default.cshtml" : $"{appName}Default.cshtml";
        string viewName = $"{path}{view}";
        return View(viewName);
    }

    public virtual IViewComponentResult GetViewName(string path, string appName, AlertList alerts)
    {
        var view = appName == ThemeType.Default.ToString() ? "Default.cshtml" : $"{appName}Default.cshtml";
        string viewName = $"{path}{view}";
        return View(viewName, alerts);
    }

    public virtual IViewComponentResult GetViewName<TModel>(string path, string appName, TModel model)
    {
        var view = appName == ThemeType.Default.ToString() ? "Default.cshtml" : $"{appName}Default.cshtml";
        string viewName = $"{path}{view}";
        return View(viewName, model);
    }
}