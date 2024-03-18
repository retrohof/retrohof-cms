using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp.Features;
using Volo.Abp.MultiTenancy;

namespace Retrohof.Features
{
    public class ViewComponentsFeatureProvider : IDomainService, IViewComponentsFeatureProvider<ViewComponent>, IMultiTenant
	{
		private readonly IFeatureChecker _featureChecker;
        private readonly ICurrentTenant _currentTenant;

        public ViewComponentsFeatureProvider(IFeatureChecker featureChecker, ICurrentTenant currentTenant)
        {
			_featureChecker = featureChecker;
            _currentTenant = currentTenant;
        }

		public async Task<bool> DisplayViewComponent<T>()
		{
			return await _featureChecker.IsEnabledAsync(typeof(T).Name.Replace("ViewComponent", ""));
		}

		public Guid? TenantId => _currentTenant.Id;

        /*
			public const string Introduction = "Introduction";
			public const string AboutUs = "AboutUs";
			public const string ChooseUs = "ChooseUs";
			public const string RecentPosts = "RecentPosts";
			public const string OpeningHours = "OpeningHours";
			public const string Testimonials = "Testimonials";
		 */

        public async Task<bool> DisplayTopNavBarToolBar<T>()
		{
			return await _featureChecker.IsEnabledAsync(ViewComponentFeatures.TopNavbarToolbar);
		}

		public async Task<bool> DisplayMainNavbar()
		{
			return await _featureChecker.IsEnabledAsync(ViewComponentFeatures.MainNavbar);
		}

		public async Task<bool> DisplaySlider()
		{
			return await _featureChecker.IsEnabledAsync(ViewComponentFeatures.Slider);
		}

		public async Task<bool> DisplaySuppliers()
		{
			return await _featureChecker.IsEnabledAsync(ViewComponentFeatures.Suppliers);
		}

		public async Task<bool> DisplayFooter()
		{
			return await _featureChecker.IsEnabledAsync(ViewComponentFeatures.Footer);
		}
	}
}
