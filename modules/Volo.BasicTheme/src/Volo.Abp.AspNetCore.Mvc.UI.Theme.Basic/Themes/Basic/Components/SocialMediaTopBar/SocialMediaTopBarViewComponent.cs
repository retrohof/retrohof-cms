using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.SocialMediaTopBar;

public class SocialMediaTopBarViewComponent : ViewComponent
{
    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/Basic/Components/SocialMediaTopBar/Default.cshtml", new SocialMediaTopBarModel());
    }
}

public class SocialMediaTopBarModel
{
    public SocialMediaTopBarModel()
    {
        Facebook = "#";
        Pinterest = "#";
        Twitter = "#";
        Instagram = "#";
        Telephone = "07930 645 116";
        Email = "mdwigmore@gmail.com";
    }

    public string Facebook { get; }
    public string Pinterest { get; }
    public string Twitter { get; }
    public string Instagram { get; }
    public string Telephone { get; }
    public string Email { get; }
}