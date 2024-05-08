using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.AboutUs;

public class AboutUsViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/AboutUs/Default.cshtml", new AboutUsModel());
    }
}

public class AboutUsModel
{
    public string Title => "About <span>Us</span>";

    public List<string> Paragraphs = 
    [
        "Hello there! My name is Erind and I have been fitting curtains and blinds as a professional for over 15-years in London and surrounding areas. During this time I have gained extensive experience in measuring and installing curtain rails & poles for most bay window shapes & sizes.",
        "Thank you for taking the time to visit our website. We look forward to hearing from you with regards to your curtain tracks or blind queries and will do our best to assist and advise."
    ];
}