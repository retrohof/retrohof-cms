using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp.Account.Web;
using Volo.Abp.Identity;

namespace Retrohof.Web.Pages.Account
{
    public class LoginExtendedModel : Volo.Abp.Account.Web.Pages.Account.LoginModel
    {
        public LoginExtendedModel(IAuthenticationSchemeProvider schemeProvider, IOptions<AbpAccountOptions> accountOptions, IOptions<IdentityOptions> identityOptions, IdentityDynamicClaimsPrincipalContributorCache identityDynamicClaimsPrincipalContributorCache) 
            : base(schemeProvider, accountOptions, identityOptions, identityDynamicClaimsPrincipalContributorCache)
        {
        }
    }
}
