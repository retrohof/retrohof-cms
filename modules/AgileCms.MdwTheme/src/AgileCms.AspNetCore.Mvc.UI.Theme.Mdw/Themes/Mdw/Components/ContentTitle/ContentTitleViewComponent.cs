using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Layout;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Mdw.Themes.Mdw.Components.ContentTitle;

public class ContentTitleViewComponent : AbpViewComponent
{
    protected IPageLayout PageLayout { get; }

    public ContentTitleViewComponent(IPageLayout pageLayout)
    {
        PageLayout = pageLayout;
    }

    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Mdw/Components/ContentTitle/Default.cshtml", PageLayout.Content);
    }
}
