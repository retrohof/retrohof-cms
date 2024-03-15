using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Suppliers;

public class SuppliersViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/Suppliers/Default.cshtml", new SuppliersModel());
    }
}

public class SuppliersModel
{
    public string Title => "Our Suppliers";

    public List<string> Urls =
    [
        @"images/suppliers/integra-logo.png",
        @"images/suppliers/hallis-hudson-logo.png",
        @"images/suppliers/lexaflux-logo.png",
        @"images/suppliers/silent-gliss-logo.png",
        @"images/suppliers/the-bradley-collection-logo.png",
        @"images/suppliers/velux-logo.png",
    ];
}