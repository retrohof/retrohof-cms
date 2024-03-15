using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Introduction;

public class IntroductionViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/Introduction/Default.cshtml", new IntroductionModel());
    }
}

public class IntroductionModel
{
    public string Title => "Welcome to ErindonTrack.com";

    public List<string> Paragraphs = 
    [
        "Based in Elmbridge Surrey, Erind onTrack is an approved supplier & fitter of made to measure bay window curtain tracks and poles. In addition we also fully install customers own Venetian, Roller, Roman Vertical blinds.",
        "Our specialist technicians are fully trained & experienced to carry out safe installations in your home. We value your trust and confidence to hire our experts with peace of mind.",
        "We currently serve within the area of West & South West London but also some parts of Surrey & Middlesex by appointment only. We offer a comprehensive service for the measuring and installation of bay window curtain tracks, poles and blinds.",
        "For more information about services and availability please contact us below. All enquiries will be replied to within 24hrs / Mon-Friday."
    ];
}