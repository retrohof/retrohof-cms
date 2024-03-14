﻿using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Layout;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.ContentTitle;

public class ContentTitleViewComponent : AgileCmsViewComponent
{
    private readonly IAgileCmsBrandingProvider _brandingProvider;

    protected IPageLayout PageLayout { get; }

    public ContentTitleViewComponent(IPageLayout pageLayout, IAgileCmsBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
        PageLayout = pageLayout;
    }

    public virtual IViewComponentResult Invoke()
    {
        return GetViewName($"~/Themes/Basic/Components/ContentTitle/", _brandingProvider.AppName, PageLayout.Content);
    }
}
