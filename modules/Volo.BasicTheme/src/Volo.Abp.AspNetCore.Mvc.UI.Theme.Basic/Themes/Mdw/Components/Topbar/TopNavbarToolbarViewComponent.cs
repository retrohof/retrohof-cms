using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Mdw.Components.Topbar;

public class TopNavbarToolbarViewComponent : AbpViewComponent
{
    //protected IMenuManager MenuManager { get; }

    //public TopNavbarToolbarViewComponent(IMenuManager menuManager)
    //{
    //    MenuManager = menuManager;
    //}

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        //var menu = await MenuManager.GetMainMenuAsync();
        return View("~/Themes/Mdw/Components/Topbar/Default.cshtml");
    }
}
