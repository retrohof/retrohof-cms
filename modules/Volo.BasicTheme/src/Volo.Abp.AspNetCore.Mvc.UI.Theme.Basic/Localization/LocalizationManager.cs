using Microsoft.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Localization;
using Volo.Abp.MultiTenancy;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Localization;

public class LocalizationManager : ILocalizationManager
{
    private readonly ICurrentTenant _currentTenant;
    private readonly IHtmlLocalizerFactory _factory;

    public LocalizationManager(ICurrentTenant currentTenant, IHtmlLocalizerFactory factory)
    {
        _currentTenant = currentTenant;
        _factory = factory;
    }

    public virtual IHtmlLocalizer GetHtmlLocalizer(string componentName)
    {
        switch (_currentTenant.Name)
        {
			case "Mdw":
				return _factory.Create(typeof(MdwResource));
			default:
				return _factory.Create(typeof(ErindOnTrackResource));
		}
	}
}
