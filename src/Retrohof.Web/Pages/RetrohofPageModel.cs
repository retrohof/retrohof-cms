using Microsoft.AspNetCore.Mvc;
using System;
using Volo.Abp.AspNetCore.Mvc.UI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

namespace Retrohof.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class RetrohofPageModel : AbpPageModel
{
    protected readonly IAgileCmsBrandingProvider _brandingProvider;

    protected RetrohofPageModel(IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;

        LocalizationResourceType = GetLocalizationResourceType();
    }

    [BindProperty(SupportsGet = true)]
    public string PageLayout { get; set; } = string.Empty;

    /*
     *  Move to own class/manager eventually
     */
    public Type GetLocalizationResourceType()
    {
        var themeType = _brandingProvider.AppName;

        switch (themeType)
        {
            case "Default":
                return typeof(BasicResource);
            case "ErindOnTrack":
                return typeof(ErindOnTrackResource);
            case "Mdw":
                return typeof(MdwResource);
            case "RetroHof":
                return typeof(RetroHofResource);
            case "South25":
                return typeof(South25Resource);
            default:
                throw new ArgumentOutOfRangeException(nameof(themeType), $"{themeType}");
        }
    }
}
