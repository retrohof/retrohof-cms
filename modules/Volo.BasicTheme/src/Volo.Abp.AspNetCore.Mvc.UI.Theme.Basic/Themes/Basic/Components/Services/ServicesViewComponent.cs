using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Services;

public class ServicesViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/Services/Default.cshtml");
    }
}

public class ServicesModel
{
    public string Title => "Our Services";

    public List<ServiceModel> Services = 
    [
        new ServiceModel("Straight/Bay Tracks", "Supply & Fit", "We offer a measure, supply and fit service for any shape window including bay & curve"),
        new ServiceModel("Curtain Poles", "Supply & Fit", "A variety of choice from traditional wood & metal poles via our online catalogue"),
        new ServiceModel("Curtains", "Hanging & Dressing", "Our fitters will hook, hang & pleat your new or existing curtains as part of our track fitting service"),
        new ServiceModel("Roller/Roman Blind", "Fit & Repair", "We fit most types of blinds and can repair/replace Roman blinds headrails"),
    ];
}

public record ServiceModel(string Name, string Options, string TagLine);
