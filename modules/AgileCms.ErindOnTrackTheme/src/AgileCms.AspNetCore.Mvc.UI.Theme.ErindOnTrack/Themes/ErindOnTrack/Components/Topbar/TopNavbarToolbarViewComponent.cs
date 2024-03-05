using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack.Themes.ErindOnTrack.Components.Topbar;

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
        return View("~/Themes/ErindOnTrack/Components/Topbar/Default.cshtml");
    }
}
