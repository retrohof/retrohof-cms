using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

[ThemeName(Name)]
public class BasicTheme : ITheme, ITransientDependency
{
    public const string Name = "Basic";

    public virtual string GetLayout(string name, bool fallbackToDefault = true)
    {
        var layout = name.Replace(".", string.Empty);

        return $"~/Themes/Basic/Layouts/{layout}.cshtml";

        //switch (name)
            //{
            //case LayoutType.Application:
            //    return $"~/Themes/Basic/Layouts/Application.cshtml";
            //case LayoutType.Account:
            //    return $"~/Themes/Basic/Layouts/Account.cshtml";
            //case LayoutType.Empty:
            //    return $"~/Themes/Basic/Layouts/Empty.cshtml";
            //case LayoutType.ErindOnTrackApplication:
            //    return $"~/Themes/Basic/EoT/Layouts/Application.cshtml";
            //case LayoutType.ErindOnTrackAccount:
            //    return $"~/Themes/Basic/EoT/Layouts/Account.cshtml";
            //case LayoutType.MdwApplication:
            //    return $"~/Themes/Basic/Layouts/Mdw/Application.cshtml";
            //case LayoutType.MdwAccount:
            //    return $"~/Themes/Basic/Layouts/Mdw/Account.cshtml";
            //case LayoutType.RetroHofApplication:
            //    return $"~/Themes/Basic/Layouts/RetroHof/Application.cshtml";
            //case LayoutType.RetroHofAccount:
            //    return $"~/Themes/Basic/Layouts/RetroHof/Account.cshtml";
            //case LayoutType.South25Application:
            //    return $"~/Themes/Basic/Layouts/South25/Application.cshtml";
            //case LayoutType.South25Account:
            //    return $"~/Themes/Basic/Layouts/South25/Account.cshtml";
            //default:
            //    //throw new FileNotFoundException(nameof(name));
            //    return fallbackToDefault ? "~/Themes/Basic/Layouts/Application.cshtml" : null;
        //}
    }
}

public class PageType
{
    public const string Application = "Application";
    public const string Account = "Account";
    public const string Empty = "Empty";
}

public class LayoutType
{
    public const string Application = "Application";
    public const string Account = "Account";
    public const string Empty = "Empty";

    public const string ErindOnTrackApplication = "ErindOnTrack.Application";
    public const string ErindOnTrackAccount = "ErindOnTrack.Account";

    public const string MdwApplication = "Mdw.Application";
    public const string MdwAccount = "Mdw.Account";

    public const string RetroHofApplication = "RetroHof.Application";
    public const string RetroHofAccount = "RetroHof.Account";

    public const string South25Application = "South25.Application";
    public const string South25Account = "South25.Account";
}

public enum ThemeType
{
    Default,
    ErindOnTrack,
    Mdw,
    RetroHof,
    South25
}

public interface IThemeLayoutManager
{
    string GetThemeLayout(string pageType);
}

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
