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
        @"/themes/erindOnTrack/images/suppliers/integra-logo.png",
        @"/themes/erindOnTrack/images/suppliers/hallis-hudson-logo.png",
        @"/themes/erindOnTrack/images/suppliers/lexaflux-logo.png",
        @"/themes/erindOnTrack/images/suppliers/silent-gliss-logo.png",
        @"/themes/erindOnTrack/images/suppliers/the-bradley-collection-logo.png",
        @"/themes/erindOnTrack/images/suppliers/velux-logo.png",
    ];
}