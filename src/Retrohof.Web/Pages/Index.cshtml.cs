using Microsoft.AspNetCore.Mvc;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Users;

namespace Retrohof.Web.Pages;

public class IndexModel : RetrohofPageModel
{
    public IndexModel(ICanvasThemeBrandingProvider brandingProvider) : base(brandingProvider)
    {
    }

    [BindProperty(SupportsGet = true)]
    public string LongWelcomeMessage => L["LongWelcomeMessage"];

    [BindProperty(SupportsGet = true)]
    public string Login => L["Login"];

	public string DisplayUser(ICurrentUser user)
	{
		return new StringBuilder($"<p>&nbsp;</p><h5>User Info:</h5> <div>User ID:<b>{user.Id}:</b></br>Name:<b>{user.Name}</b></div>").ToString();
	}

	public string DisplayTenant(ICurrentTenant tenant)
	{
		return new StringBuilder($"<h5>Tenant Info:</h5> <div>Tenant ID:<b>{tenant.Id}</b></br>Name:<b>{tenant.Name}</b></div>").ToString();
	}

	public void OnGet()
    {
   }
}
