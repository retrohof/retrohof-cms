using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

namespace Retrohof.Web.Pages;

public class IndexModel : RetrohofPageModel
{
    public IndexModel(IAgileCmsBrandingProvider brandingProvider) : base(brandingProvider)
    {
    }

    [BindProperty(SupportsGet = true)]
    public string LongWelcomeMessage => L["LongWelcomeMessage"];

    [BindProperty(SupportsGet = true)]
    public string Login => L["Login"];

    public void OnGet()
    {
   }
}
