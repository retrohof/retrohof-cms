using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25.Themes.South25.Components.Slider;

public class SliderViewComponent : AbpViewComponent
{
    public SliderViewComponent()
    {
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View("~/Themes/South25/Components/Slider/Default.cshtml", new SliderResourceViewModel());
    }
}

public class SliderResourceViewModel
{
    public readonly string Slide1 = @"Slider|Index|Slide|1";
    public readonly string Slide2 = @"Slider|Index|Slide|2";
    public readonly string Slide3 = @"Slider|Index|Slide|3";
}
