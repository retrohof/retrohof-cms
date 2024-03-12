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
            case EoTLayouts.Application:
                return $"~/Themes/Basic/EoT/Layouts/Application.cshtml";
            case EoTLayouts.Account:
                return $"~/Themes/Basic/EoT/Layouts/Account.cshtml";
            case EoTLayouts.Empty:
                return $"~/Themes/Basic/EoT/Layouts/Empty.cshtml";
            case MdwLayouts.Application:
                return $"~/Themes/Basic/Layouts/Mdw/Application.cshtml";
            case MdwLayouts.Account:
                return $"~/Themes/Basic/Layouts/Mdw/Account.cshtml";
            case MdwLayouts.Empty:
                return $"~/Themes/Basic/Layouts/Mdw/Empty.cshtml";
            case RetroHofLayouts.Application:
                return $"~/Themes/Basic/Layouts/RetroHof/Application.cshtml";
            case RetroHofLayouts.Account:
                return $"~/Themes/Basic/Layouts/RetroHof/Account.cshtml";
            case RetroHofLayouts.Empty:
                return $"~/Themes/Basic/Layouts/RetroHof/Empty.cshtml";
            case South25Layouts.Application:
                return $"~/Themes/Basic/Layouts/South25/Application.cshtml";
            case South25Layouts.Account:
                return $"~/Themes/Basic/Layouts/South25/Account.cshtml";
            case South25Layouts.Empty:
                return $"~/Themes/Basic/Layouts/South25/Empty.cshtml";
            default:
                throw new FileNotFoundException(nameof(name));
                //return fallbackToDefault ? "~/Themes/Basic/Layouts/Application.cshtml" : null;
        }
    }
}

public static class EoTLayouts
{
    public const string Application = "ErindOnTrack.Application";

    public const string Admin = "ErindOnTrack.Admin";

    public const string Public = "ErindOnTrack.Public";

    public const string Account = "ErindOnTrack.Account";

    public const string Empty = "ErindOnTrack.Empty";
}
public static class South25Layouts
{
    public const string Application = "South25.Application";

    public const string Admin = "South25.Admin";

    public const string Public = "South25.Public";

    public const string Account = "South25.Account";

    public const string Empty = "South25.Empty";
}

public static class RetroHofLayouts
{
    public const string Application = "RetroHof.Application";

    public const string Account = "RetroHof.Account";

    public const string Public = "RetroHof.Public";

    public const string Empty = "RetroHof.Empty";
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