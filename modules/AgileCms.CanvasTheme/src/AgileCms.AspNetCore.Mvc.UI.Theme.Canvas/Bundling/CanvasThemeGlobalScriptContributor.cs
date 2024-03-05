using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Bundling;

public class CanvasThemeGlobalScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        //context.Files.Add("/themes/canvas/layout.js");
    }
}
