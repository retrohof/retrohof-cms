using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Toolbar.UserMenu;

public class UserMenuViewComponent : AbpViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    protected IMenuManager MenuManager { get; }

	public UserMenuViewComponent(IMenuManager menuManager, IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
        MenuManager = menuManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetAsync(StandardMenus.User);
        return View($"~/Themes/Basic/Components/Toolbar/UserMenu/{_brandingProvider.AppName}.cshtml", menu);
    }
}
