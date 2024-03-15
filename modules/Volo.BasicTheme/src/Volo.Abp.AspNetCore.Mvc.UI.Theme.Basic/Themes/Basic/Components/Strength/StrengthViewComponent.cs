using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Strength;

public class StrengthViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/Strength/Default.cshtml");
    }
}

public class StrengthModel
{
    public string Title => "Our Strengths & Values";

    public List<string> Paragraphs =
    [
        "Communication", 
        "Promptness", 
        "Efficiency", 
        "Courtesy", 
        "Workmanship Quality", 
        "Integrity", 
        "Respect", 
        "Honesty", 
        "Punctuality", 
        "Customer Satisfaction"
    ];
}