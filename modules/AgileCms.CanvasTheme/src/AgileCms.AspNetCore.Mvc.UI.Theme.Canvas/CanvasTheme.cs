using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas;

[ThemeName(Name)]
public class CanvasTheme : ITheme, ITransientDependency
{
    public const string Name = "Canvas";

    public string GetLayout(string name, bool fallbackToDefault = true)
    {
        throw new System.NotImplementedException();
    }
}

public interface ICanvasTheme : ITheme, ITransientDependency
{
    string GetLayout(string name, string layout, bool fallbackToDefault = true);
}