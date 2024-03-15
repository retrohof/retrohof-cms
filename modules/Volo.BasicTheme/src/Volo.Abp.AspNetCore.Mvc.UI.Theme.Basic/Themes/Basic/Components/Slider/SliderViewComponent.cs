using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Slider;

public class SliderViewComponent : ViewComponent
{
	public virtual async Task<IViewComponentResult> InvokeAsync()
	{
		return View("~/Themes/Basic/Components/Slider/Default.cshtml", new SliderViewModel());
	}
}

public class SliderViewModel
{
    public List<SlideResourceViewModel> Slides => new List<SlideResourceViewModel> {
        new SlideResourceViewModel(
            Title: @"Custom Curtain and Blind Fitting",
            SubTitle: @"Transform Your Home with Tailored Window Solutions",
            CallToAction: "Call for Free Quote",
            Results: [
                new ResultResourceViewModel("Transform Your Space with Expertly Fitted Curtains and Blinds"),
                new ResultResourceViewModel("Elevate Your Home's Style and Comfort with Our Seamless Installation Services!"),
            ]),
        new SlideResourceViewModel(
            Title: @"Straight & Bay Tracks",
            SubTitle: @"Full width tracks for bi-fold doors",
            CallToAction: "Request a Quote",
            Results: [
                new ResultResourceViewModel("Revitalize Your Living Spaces"),
                new ResultResourceViewModel(" Immerse Your Home in Elegance with Our Expertly Fitted Curtains and Blinds!"),
            ]),
        new SlideResourceViewModel(
            Title: @"Roller & Roman Blinds",
            SubTitle: @"Fitting, refitting & repairs",
            CallToAction: "Get Advice",
            Results: [
                new ResultResourceViewModel("Experience the Art of Tailored Comfort"),
                new ResultResourceViewModel("Precision-Fitted Curtains and Blinds - Where Tranquility Meets Style!")
            ]),
        };
}

public record SlideResourceViewModel(string Title, string SubTitle, string CallToAction, ResultResourceViewModel[] Results);
public record ResultResourceViewModel(string Value);

/*
	public readonly string Slide1Title = @"Curtain & Blind Fitting";
    public readonly string Slide1Subtitle = @"Specialists in straight or window bay tracks";
     public readonly string Slide2Title = @"Straight & Bay Tracks";
    public readonly string Slide2Subtitle = @"Full width tracks for bi-fold doors";
    public readonly string Slide3Title = @"Roller & Roman Blinds";
    public readonly string Slide3Subtitle = @"Fitting, refitting & repairs";
 */