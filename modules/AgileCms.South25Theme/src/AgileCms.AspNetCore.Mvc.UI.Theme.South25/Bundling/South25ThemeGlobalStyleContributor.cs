using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25.Bundling;

public class South25ThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        //context.Files.Add("/themes/canvas/layout.css");
    }
}
