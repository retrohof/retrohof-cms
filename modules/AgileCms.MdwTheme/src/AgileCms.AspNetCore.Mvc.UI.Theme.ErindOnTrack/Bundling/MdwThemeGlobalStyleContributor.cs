using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Mdw.Bundling;

public class MdwThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        //context.Files.Add("/themes/erindOnTrack/layout.css");
    }
}
