﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Themes.Canvas.Components.Toolbar.UserMenu;

public class UserMenuViewComponent : AbpViewComponent
{
    protected IMenuManager MenuManager { get; }

    public UserMenuViewComponent(IMenuManager menuManager)
    {
        MenuManager = menuManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetAsync(StandardMenus.User);
        return View("~/Themes/Canvas/Components/Toolbar/UserMenu/Default.cshtml", menu);
    }
}