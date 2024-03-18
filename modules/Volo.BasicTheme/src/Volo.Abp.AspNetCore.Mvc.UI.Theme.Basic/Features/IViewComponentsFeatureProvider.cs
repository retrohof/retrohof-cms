using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Retrohof.Features
{
	public interface IViewComponentsFeatureProvider<T> where T : ViewComponent
	{
		Task<bool> DisplayViewComponent<T>();

		//Task<bool> DisplayTopNavBarToolBar<T>();
		//Task<bool> DisplayMainNavbar<T>();
		//Task<bool> DisplaySlider<T>();
		//Task<bool> DisplaySuppliers<T>();
		//Task<bool> DisplayFooter<T>();

		/*
			public const string Introduction = "Introduction";
			public const string AboutUs = "AboutUs";
			public const string ChooseUs = "ChooseUs";
			public const string RecentPosts = "RecentPosts";
			public const string OpeningHours = "OpeningHours";
			public const string Testimonials = "Testimonials";
		 */
	}
}
