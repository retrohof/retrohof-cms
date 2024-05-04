using Microsoft.AspNetCore.Mvc.Localization;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Localization;

public interface ILocalizationManager : ITransientDependency
{
    IHtmlLocalizer GetHtmlLocalizer(string componentName);
}
