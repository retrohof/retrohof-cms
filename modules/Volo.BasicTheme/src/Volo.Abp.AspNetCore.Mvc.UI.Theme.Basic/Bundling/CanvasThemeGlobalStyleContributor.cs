using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling;

public class CanvasThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add("/themes/mdw/style.css");
        context.Files.Add("/css/font-icons.css");
        context.Files.Add("/css/swiper.css");
        context.Files.Add("/css/custom.css");
    }
}