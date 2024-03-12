using Volo.Abp.Ui.Branding;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

public class AgileCmsBrandingProvider : DefaultBrandingProvider, IAgileCmsBrandingProvider
{
    public string? ShortName => "Default";
}

public interface IAgileCmsBrandingProvider : IBrandingProvider
{
    public string? ShortName => "Default";

}