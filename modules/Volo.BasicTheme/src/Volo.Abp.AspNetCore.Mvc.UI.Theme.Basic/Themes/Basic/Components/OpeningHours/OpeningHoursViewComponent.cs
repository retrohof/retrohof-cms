using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.OpeningHours;

public class OpeningHoursViewComponent : ViewComponent
{
	public virtual IViewComponentResult Invoke()
	{
		return View("~/Themes/Basic/Components/OpeningHours/Default.cshtml", new OpeningHoursModel());
	}
}

public class OpeningHoursModel
{
	public string Title => "Opening Hours";

	public string TagLine => "Call us anytime for a free quote or advise. ";

	public List<OpeningHourModel> Hours =
	[
		new OpeningHourModel(
			"Mondays-Fridays:",
			"9AM to 6PM"),
		new OpeningHourModel(
			"Saturdays:",
			"10AM to 2PM"),
		new OpeningHourModel(
			"Sundays:",
			"Closed")
	];
}

public record OpeningHourModel(string Days, string Times);
