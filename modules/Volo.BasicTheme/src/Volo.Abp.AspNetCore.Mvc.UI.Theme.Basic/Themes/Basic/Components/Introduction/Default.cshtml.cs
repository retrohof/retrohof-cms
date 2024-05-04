using Microsoft.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Introduction;

public class DefaultModel
{
    private readonly ILocalizationManager _localizationManager;

    public DefaultModel(ILocalizationManager localizationManager)
    {
        _localizationManager = localizationManager;
    }

    public IHtmlLocalizer L
    {
        get
        {
            return _localizationManager.GetHtmlLocalizer();
        }
    }
}
