using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers;

public class SliderProvider : ISliderProvider, ITransientDependency
{
    public string Slide1Title => @"Curtain & Blind Fitting";
    public string Slide1Subtitle => @"Specialists in straight or window bay tracks";
    public string Slide2Title => @"Straight & Bay Tracks";
    public string Slide2Subtitle => @"Full width tracks for bi-fold doors";
    public string Slide3Title => @"Roller & Roman Blinds";
    public string Slide3Subtitle => @"Fitting, refitting & repairs";
}

public interface ISliderProvider
{
    string Slide1Title { get; }
    string Slide1Subtitle { get; }
    string Slide2Subtitle { get; }
    string Slide2Title { get; }
    string Slide3Subtitle { get; }
    string Slide3Title { get; }
}
