﻿using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack;

[ThemeName(Name)]
public class ErindOnTrackTheme : ITheme, ITransientDependency
{
    public const string Name = "ErindOnTrack";

    public string GetLayout(string name, bool fallbackToDefault = true)
    {
        throw new System.NotImplementedException();
    }
}
