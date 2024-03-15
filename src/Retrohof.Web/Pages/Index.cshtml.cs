using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;
using Volo.Abp.Users;

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

	public string DisplayUser(ICurrentUser user)
	{
		return new StringBuilder($"<b>USER INFO:</b> <p>User ID: {user.Id}:</p><p>Name:{user.Name}</p>").ToString();
	}

	public string DisplayTenant(ICurrentTenant tenant)
	{
		return new StringBuilder($"<b>TENANT INFO:</b> <p>Tenant ID: {tenant.Id}</p><p>Name:{tenant.Name}</p>").ToString();
	}

	public void OnGet()
    {
   }
}
