using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.ChooseUs;

public class ChooseUsViewComponent : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Basic/Components/ChooseUs/Default.cshtml", new ChooseUsModel());
    }
}

public class ChooseUsModel
{
    public string Title => "Why Choose Us?";

    public List<ChoiceModel> Choices =
    [
        new ChoiceModel( "Polite, prompt & professional"),
        new ChoiceModel("Competitively priced"),
        new ChoiceModel("Bay window specialist"),
        new ChoiceModel("Curtain hanging service"),
        new ChoiceModel("Roman blinds supplied & fitted"),
        new ChoiceModel("Roller blinds fitted"),
        new ChoiceModel("Venetian fitted"),
        new ChoiceModel("Approved Silent Gliss supplier"),
		new ChoiceModel("Trade & customer references available", ""),
        new ChoiceModel("Supply and installation", "Installation only applicable to curtain poles only"),
        new ChoiceModel("Roman blind repairs", "New winder systems and cord rethreading"),
        new ChoiceModel("End of tenancy", "Curtain & blind restoration"),
        new ChoiceModel("Track repairs and records", "Only certain contract rails"),
        new ChoiceModel("Fully insured", "Covered up to £1m PLI"),
        new ChoiceModel("Guarantee", "All installation work is guaranteed for 12-month"),
    ];
}

public record ChoiceModel(string Title, string Additional = "");