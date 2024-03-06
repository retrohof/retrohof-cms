using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25;

[ThemeName(Name)]
public class South25Theme : ITheme, ITransientDependency
{
    public const string Name = "South25";

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
            case CanvasLayouts.Application:
                return $"~/Themes/Canvas/Layouts/Application.cshtml";
            case CanvasLayouts.Account:
                return $"~/Themes/Canvas/Layouts/Account.cshtml";
            case CanvasLayouts.Empty:
                return $"~/Themes/Canvas/Layouts/Empty.cshtml";
            case ErindOnTrackLayouts.Application:
                return $"~/Themes/ErindOnTrack/Layouts/Application.cshtml";
            case ErindOnTrackLayouts.Account:
                return $"~/Themes/ErindOnTrack/Layouts/Account.cshtml";
            case ErindOnTrackLayouts.Empty:
                return $"~/Themes/ErindOnTrack/Layouts/Empty.cshtml";
            case South25Layouts.Application:
                return $"~/Themes/South25/Layouts/Application.cshtml";
            case South25Layouts.Account:
                return $"~/Themes/South25/Layouts/Account.cshtml";
            case South25Layouts.Empty:
                return $"~/Themes/ErindOnTrack/Layouts/Empty.cshtml";
            case MdwLayouts.Application:
                return $"~/Themes/Mdw/Layouts/Application.cshtml";
            case MdwLayouts.Account:
                return $"~/Themes/Mdw/Layouts/Account.cshtml";
            case MdwLayouts.Empty:
                return $"~/Themes/Mdw/Layouts/Empty.cshtml";
            default:
                return fallbackToDefault ? "~/Themes/Basic/Layouts/Application.cshtml" : null;
        }
    }
}

public static class MdwLayouts
{
    public const string Application = "Mdw.Application";

    public const string Account = "Mdw.Account";

    public const string Public = "Mdw.Public";

    public const string Empty = "Mdw.Empty";
}

public static class CanvasLayouts
{
    public const string Application = "Canvas.Application";

    public const string Admin = "Canvas.Admin";

    public const string Public = "Canvas.Public";

    public const string Account = "Canvas.Account";

    public const string Empty = "Canvas.Empty";
}

public static class South25Layouts
{
    public const string Application = "South25.Application";

    public const string Admin = "South25.Admin";

    public const string Public = "South25.Public";

    public const string Account = "South25.Account";

    public const string Empty = "South25.Empty";
}

public static class ErindOnTrackLayouts
{
    public const string Application = "ErindOnTrack.Application";

    public const string Admin = "ErindOnTrack.Admin";

    public const string Public = "ErindOnTrack.Public";

    public const string Account = "ErindOnTrack.Account";

    public const string Empty = "ErindOnTrack.Empty";
}

public static class BasicLayouts
{
    public const string Application = "Basic.Application";

    public const string Account = "Basic.Account";

    public const string Public = "Basic.Public";

    public const string Empty = "Basic.Empty";
}

public interface IErindOnTrackTheme : ITheme, ITransientDependency
{
    string GetLayout(string name, string layout, bool fallbackToDefault = true);
}