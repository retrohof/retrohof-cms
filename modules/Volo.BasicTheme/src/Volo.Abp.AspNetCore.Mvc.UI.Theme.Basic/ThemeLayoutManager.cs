﻿using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

public class ThemeLayoutManager : IThemeLayoutManager, ITransientDependency
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    public ThemeLayoutManager(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    public virtual string GetThemeLayout(string pageType)
    {
        var appName = _brandingProvider.AppName == "Default" ? string.Empty : _brandingProvider.AppName;
        var layout = $"{appName}{pageType}";

        return $"~/Themes/Basic/Layouts/{layout}.cshtml";
    }
}
