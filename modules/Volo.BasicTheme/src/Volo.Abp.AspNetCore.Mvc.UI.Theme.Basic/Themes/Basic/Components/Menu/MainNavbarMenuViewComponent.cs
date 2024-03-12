using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Menu;

public class MainNavbarMenuViewComponent : AbpViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    protected IMenuManager MenuManager { get; }

    public MainNavbarMenuViewComponent(IMenuManager menuManager, IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
        MenuManager = menuManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetMainMenuAsync();
        return View($"~/Themes/Basic/Components/Menu/{_brandingProvider.AppName}.cshtml", menu);
    }
}
