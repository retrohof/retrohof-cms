using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;

namespace Retrohof.Web.Pages;

public class ApplicationModel : PageModel
{
    private readonly ICanvasThemeBrandingProvider _brandingProvider;

    public ApplicationModel(ICanvasThemeBrandingProvider brandingProvider)
    {
        _brandingProvider = brandingProvider;
    }

    [BindProperty(SupportsGet = true)]
    public string LongWelcomeMessage { get; set; }

    [BindProperty(SupportsGet = true)]
    public string Login { get; set; }

    public void OnGet()
    {
   }
}
