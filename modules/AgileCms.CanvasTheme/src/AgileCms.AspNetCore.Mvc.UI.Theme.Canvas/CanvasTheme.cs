using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas;

[ThemeName(Name)]
public class CanvasTheme : BasicTheme, ITransientDependency
{
    public new const string Name = "Canvas";
}

public interface ICanvasTheme : ITheme, ITransientDependency
{
    string GetLayout(string name, string layout, bool fallbackToDefault = true);
}