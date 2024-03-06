using System.Collections.Generic;
using Volo.Abp.Localization;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25.Themes.South25.Components.Toolbar.LanguageSwitch;

public class LanguageSwitchViewComponentModel
{
    public LanguageInfo CurrentLanguage { get; set; }

    public List<LanguageInfo> OtherLanguages { get; set; }
}
