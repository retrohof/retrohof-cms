using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Retrohof.Permissions;

namespace CmsKitDemo.Pages.Gallery.Management
{
    [Authorize(RetrohofPermissions.GalleryImage.Management)]
    public class ManagementModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
