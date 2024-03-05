﻿using Volo.Abp.AspNetCore.Mvc.UI.Theming;
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
            default:
                return fallbackToDefault ? "~/Themes/Basic/Layouts/Application.cshtml" : null;
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

public static class BasicLayouts
{
    public const string Application = "Basic.Application";

    public const string Account = "Basic.Account";

    public const string Public = "Basic.Public";

    public const string Empty = "Basic.Empty";
}