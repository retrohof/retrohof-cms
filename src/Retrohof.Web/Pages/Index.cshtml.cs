using Microsoft.AspNetCore.Mvc;
using System;
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
		return $"User ID:{Environment.NewLine} ID:{user.Id}{Environment.NewLine} {Environment.NewLine}  Name:{user.Name}";
	}

	public string DisplayTenant(ICurrentTenant tenant)
	{
		return $"Tenant ID:{Environment.NewLine} ID:{tenant.Id}{Environment.NewLine} {Environment.NewLine}  Name:{tenant.Name}";
	}

	public void OnGet()
    {
   }
}
