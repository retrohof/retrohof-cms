using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.FeaturedWorks;
public class FeaturedWorksViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/FeaturedWorks/Default.cshtml", new FeaturedWorksModel());
    }
}

public class FeaturedWorksModel
{
    public string Title => "Some of our Featured Works";
	public string Subtitle => "We have worked on some Awesome Projects that are worth boasting of.";

	public List<FeaturedWorkModel> FeaturedWorks =
    [
        new FeaturedWorkModel( "Polite, prompt & professional"),
        new FeaturedWorkModel("Competitively priced"),
        new FeaturedWorkModel("Bay window specialist"),
        new FeaturedWorkModel("Curtain hanging service"),
        new FeaturedWorkModel("Roman blinds supplied & fitted"),
        new FeaturedWorkModel("Roller blinds fitted"),
        new FeaturedWorkModel("Venetian fitted"),
        new FeaturedWorkModel("Approved Silent Gliss supplier"),
		new FeaturedWorkModel("Trade & customer references available", ""),
        new FeaturedWorkModel("Supply and installation", "Installation only applicable to curtain poles only"),
        new FeaturedWorkModel("Roman blind repairs", "New winder systems and cord rethreading"),
        new FeaturedWorkModel("End of tenancy", "Curtain & blind restoration"),
        new FeaturedWorkModel("Track repairs and records", "Only certain contract rails"),
        new FeaturedWorkModel("Fully insured", "Covered up to £1m PLI"),
        new FeaturedWorkModel("Guarantee", "All installation work is guaranteed for 12-month"),
    ];
}

public record FeaturedWorkModel(string Title, string Additional = "");