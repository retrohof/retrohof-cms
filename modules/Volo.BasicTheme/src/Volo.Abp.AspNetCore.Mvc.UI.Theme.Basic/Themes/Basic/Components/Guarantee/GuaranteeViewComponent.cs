using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Guarantee;

public class GuaranteeViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/Guarantee/Default.cshtml");
    }
}

public class GuaranteeModel
{
    public string Title => "Our Guarantee & Peace Of Mind";

    public List<string> Paragraphs =
    [
        "We enjoy our work and thus aim to never fall short in service. Over the many years serving in this trade we’ve grown and developed my our own method style of workmanship with the idea of always improving. One of our favourite quotes goes something like ”If you can’t do great things, do small things in a great way”.",
        "All installations carried out by us are offered with a 12month workmanship guarantee in addition most tracking systems supplied by ErinonTrack.com come with a 5-year guarantee for added peace of mind.",
        "Please note that our guarantee only applies to the labor (product warranties are not included in the workmanship guarantee). If our labor shall fail to be up to standards within twelve months after the date of completion, we shall return to repair at our own cost.",
        "This warranty will not be applicable and subject to  void if a damage has occurred due  to misuse, negligence, or abuse by the customer/client, or carry out of work at the site by a party other than erindontrack.com"
    ];
}