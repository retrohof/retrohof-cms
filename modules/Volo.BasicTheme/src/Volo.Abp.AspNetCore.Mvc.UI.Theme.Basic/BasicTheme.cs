using System.IO;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

[ThemeName(Name)]
public class BasicTheme : ITheme, ITransientDependency
{
    public const string Name = "Basic";

    public virtual string GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case BasicLayouts.Application:
                return $"~/Themes/Basic/Layouts/Application.cshtml";
            case BasicLayouts.Account:
                return $"~/Themes/Basic/Layouts/Account.cshtml";
            case BasicLayouts.Empty:
                return $"~/Themes/Basic/Layouts/Empty.cshtml";
            case ErindOnTrackLayouts.Application:
                return $"~/Themes/Basic/EoT/Layouts/Application.cshtml";
            case ErindOnTrackLayouts.Account:
                return $"~/Themes/Basic/EoT/Layouts/Account.cshtml";
            case ErindOnTrackLayouts.Empty:
                return $"~/Themes/Basic/EoT/Layouts/Empty.cshtml";
            case MdwLayouts.Application:
                return $"~/Themes/Basic/Layouts/Mdw/Application_.cshtml";
            case MdwLayouts.Account:
                return $"~/Themes/Basic/Layouts/Mdw/Account.cshtml";
            case MdwLayouts.Empty:
                return $"~/Themes/Basic/Layouts/Mdw/Empty.cshtml";
            default:
                throw new FileNotFoundException(nameof(name));
                //return fallbackToDefault ? "~/Themes/Basic/Layouts/Application.cshtml" : null;
        }
    }
}

public static class ErindOnTrackLayouts
{
    public const string Application = "ErindOnTrack.Application";

    public const string Admin = "ErindOnTrack.Admin";

    public const string Public = "ErindOnTrack.Public";

    public const string Account = "ErindOnTrack.Account";

    public const string Empty = "ErindOnTrack.Empty";
}
public static class CanvasLayouts
{
    public const string Application = "Canvas.Application";

    public const string Admin = "Canvas.Admin";

    public const string Public = "Canvas.Public";

    public const string Account = "Canvas.Account";

    public const string Empty = "Canvas.Empty";
}

public static class MdwLayouts
{
    public const string Application = "Mdw.Application";

    public const string Account = "Mdw.Account";

    public const string Public = "Mdw.Public";

    public const string Empty = "Mdw.Empty";
}

public static class BasicLayouts
{
    public const string Application = "Application";

    public const string Account = "Account";

    public const string Public = "Public";

    public const string Empty = "Empty";
}