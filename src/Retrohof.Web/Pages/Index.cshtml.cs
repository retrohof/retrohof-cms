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
		return new StringBuilder($"User ID:{Environment.NewLine} {user.Id}{Environment.NewLine} {Environment.NewLine} Name:{user.Name}").ToString();
	}

	public string DisplayTenant(ICurrentTenant tenant)
	{
		return new StringBuilder($"Tenant ID:{Environment.NewLine} {tenant.Id}{Environment.NewLine} {Environment.NewLine} Name:{tenant.Name}").ToString();
	}

	public void OnGet()
    {
   }
}
