using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

public class ThemeLayoutManager : IThemeLayoutManager, ITransientDependency
{
    private readonly ICanvasThemeBrandingProvider _brandingProvider;

    public ThemeLayoutManager(ICanvasThemeBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual string GetThemeLayout()
    {
        return GetThemeLayout(null);
    }

    public virtual string GetThemeLayout(string pageType)
    {
        if (string.IsNullOrEmpty(pageType))
        {
            return $"~/Themes/Basic/Layouts/Empty.cshtml";
        }

        var appName = _brandingProvider.AppName == "Default" ? string.Empty : _brandingProvider.AppName;
        var layout = $"{appName}{pageType}";

        return $"~/Themes/Basic/Layouts/{layout}.cshtml";
    }
}
