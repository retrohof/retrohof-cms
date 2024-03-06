using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25;

[ThemeName(Name)]
public class South25Theme : ITheme, ITransientDependency
{
    public const string Name = "South25";

    public string GetLayout(string name, bool fallbackToDefault = true)
    {
        throw new System.NotImplementedException();
    }
}
