using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Toolbar;

public class MainNavbarToolbarViewComponent : AgileCmsViewComponent
{
    private readonly ICanvasThemeBrandingProvider _brandingProvider;

    protected IToolbarManager ToolbarManager { get; }

    public MainNavbarToolbarViewComponent(IToolbarManager toolbarManager, ICanvasThemeBrandingProvider brandingProvider)
	{
        _brandingProvider = brandingProvider;
        ToolbarManager = toolbarManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var toolbar = await ToolbarManager.GetAsync(StandardToolbars.Main);
        return GetViewName($"~/Themes/Basic/Components/Toolbar/", _brandingProvider.AppName, toolbar);
    }
}
