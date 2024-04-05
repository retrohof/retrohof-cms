using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Toolbar.UserMenu;

public class UserMenuViewComponent : AgileCmsViewComponent
{
    private readonly ICanvasThemeBrandingProvider _brandingProvider;

    protected IMenuManager MenuManager { get; }

	public UserMenuViewComponent(IMenuManager menuManager, ICanvasThemeBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
        MenuManager = menuManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetAsync(StandardMenus.User);
        return GetViewName($"~/Themes/Basic/Components/Toolbar/UserMenu/", _brandingProvider.AppName, menu);
    }
}
