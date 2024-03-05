using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack;

[ThemeName(Name)]
public class ErindOnTrackTheme : BasicTheme, ITransientDependency
{
    public new const string Name = "ErindOnTrack";

}

public interface IErindOnTrackTheme : ITheme, ITransientDependency
{
    string GetLayout(string name, string layout, bool fallbackToDefault = true);
}