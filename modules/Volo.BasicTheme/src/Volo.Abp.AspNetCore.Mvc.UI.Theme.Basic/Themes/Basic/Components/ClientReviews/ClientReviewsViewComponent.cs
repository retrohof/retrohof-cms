using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.ClientReviews;

public class ClientReviewsViewComponent : ViewComponent
{
	public virtual IViewComponentResult Invoke()
	{
		return View("~/Themes/Basic/Components/ClientReviews/Default.cshtml", new ClientReviewsModel());
	}
}

public class ClientReviewsModel
{
	public string Title => "Client Testimonials";
	public string Subtitle => "Check out some of our Client Reviews";

	public List<ClientReviewModel> ClientReviewModels =
	[
		new ClientReviewModel(
			"/themes/erindOnTrack/images/testimonials/d.jpg",
			"Debbie Ward",
			"Erind provided a professional job start to finish.  Providing new heavy duty curtain tracks and curtain pole, guided us to where we could have the best quality blinds and curtains made for our entire home. Today he came and fitted the blinds and hung the curtains. Fantastic job. We are so pleased. Thank you. Debbie & Michael.",
			new DateTime(2024, 2, 29)),
		new ClientReviewModel(
			"/themes/erindOnTrack/images/testimonials/blocked.jpg",
			"Isablelle Rowe",
			"So thrilled with my curtain track/pole! Erind was very nice, professional and a really impressive turn around between order and fit. Couldn't be happier and will definitely recommend him to others. Thank you!",
			new DateTime(2024, 1, 12)),
		new ClientReviewModel(
			"/themes/erindOnTrack/images/testimonials/mike.jpg",
			"PepaMike Hoare Gonzalez",
			"Highly recommended, lovely guy and great job too!",
			new DateTime(2024, 2, 29)),
		new ClientReviewModel(
			"/themes/erindOnTrack/images/testimonials/s.jpg",
			"Sara Anderson",
			"Erind is fast to respond, super helpful and his work is very professional and the track glides so smoothly cannot recommend highly enough ! In fact already told him I will use him again when I need the blinds put up in my loft extension",
			new DateTime(2024, 1, 12)),
		new ClientReviewModel(
			"/themes/erindOnTrack/images/testimonials/s-blue.jpg",
			"Stephanie Lang",
			"Excellent service. Quick replies, helpful discussion, and installation works perfectly",
			new DateTime(2024, 1, 12)),
	];
}

public record ClientReviewModel(string ImageSrc, string Name, string Comment, DateTime Date);
