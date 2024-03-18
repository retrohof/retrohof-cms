using System.Collections.Generic;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers
{
	public interface IDefaultPageComponentsProvider
	{
		List<ViewComponentRecord> EnabledViewComponents { get; }
	}

	public class DefaultPageComponentsProvider : IDefaultPageComponentsProvider, ITransientDependency
	{
        public DefaultPageComponentsProvider()
		{
			EnabledViewComponents = new List<ViewComponentRecord>();
			EnabledViewComponents = [
				new ViewComponentRecord("TopNavbarToolbar"),
				new ViewComponentRecord("MainNavbar"),
				new ViewComponentRecord("Slider"),
				new ViewComponentRecord("Suppliers"),
				new ViewComponentRecord("Footer")
			];
		}

        public virtual List<ViewComponentRecord> EnabledViewComponents { get; }
	}
	public class HomePageComponentsProvider : DefaultPageComponentsProvider, IHomePageComponentsProvider
	{
        public HomePageComponentsProvider() : base()
        {
			EnabledViewComponents.AddRange([
				new ViewComponentRecord("Introduction"),
					new ViewComponentRecord("AboutUs"),
					new ViewComponentRecord("ChooseUs"),
					new ViewComponentRecord("RecentPosts"),
					new ViewComponentRecord("OpeningHours"),
					new ViewComponentRecord("Testimonials")
				]);
		}

		//public override List<ViewComponentRecord> EnabledViewComponents { get; }
	}

	public interface IHomePageComponentsProvider : IDefaultPageComponentsProvider
	{
	}

	public record ViewComponentRecord(string Name);
}
