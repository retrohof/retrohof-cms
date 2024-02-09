using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Retrohof.Web;

[Dependency(ReplaceServices = true)]
public class RetrohofBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Retrohof";
}
