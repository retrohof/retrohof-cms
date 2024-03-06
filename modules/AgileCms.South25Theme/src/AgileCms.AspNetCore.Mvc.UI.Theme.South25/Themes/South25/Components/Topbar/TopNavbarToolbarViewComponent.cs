using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25.Themes.South25.Components.Topbar;

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
        return View("~/Themes/South25/Components/Topbar/Default.cshtml");
    }
}
