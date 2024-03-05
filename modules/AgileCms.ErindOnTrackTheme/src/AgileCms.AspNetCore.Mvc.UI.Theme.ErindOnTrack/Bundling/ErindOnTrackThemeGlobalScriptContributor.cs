using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack.Bundling;

public class ErindOnTrackThemeGlobalScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        //context.Files.Add("/themes/erindOnTrack/layout.js");
    }
}
