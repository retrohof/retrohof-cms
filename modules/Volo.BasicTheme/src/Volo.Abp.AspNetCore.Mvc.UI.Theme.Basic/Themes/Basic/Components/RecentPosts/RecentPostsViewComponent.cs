using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.RecentPosts;

public class RecentPostsViewComponent : ViewComponent
{
	public virtual IViewComponentResult Invoke()
	{
		return View("~/Themes/Basic/Components/RecentPosts/Default.cshtml", new RecentPostsModel());
	}
}

public class RecentPostsModel
{
	public string Title => "Recent Posts";

	public List<RecentPostModel> Posts =
	[
		new RecentPostModel(
			"/images/posts/blog-post-1.jpg",
			"Custom made SG 3900 corded bay curtain rail. Pulleys at both ends for independent movement. Great fit!",
			"#",
			new DateTime(2024, 2, 29),
			"Our customer was fed of her existing old curtain rail where the cord would constantly jam when pulled across but also many times track gliders",
			8),
		new RecentPostModel(
			"/images/posts/blog-post-2.jpg",
			"Bay Window fitted with 5x Bend Made to Measure Metal Curtain Rail in Long Ditton KT6",
			"#",
			new DateTime(2024, 1, 12),
			"Our client made an enquiry via our website contact form looking for someone to supply and fit a bespoke curtain rail for a unique shaped",
			13),
	];
}

public record RecentPostModel(string ImageSrc, string Title, string HRef, DateTime Date, string Introduction, int CommentCount);
