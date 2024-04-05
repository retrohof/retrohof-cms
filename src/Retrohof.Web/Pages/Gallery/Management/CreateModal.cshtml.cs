using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Retrohof.GalleryImages;
using Retrohof.GalleryImages.Dtos;
using Retrohof.Permissions;
using System.Threading.Tasks;

namespace CmsKitDemo.Pages.Gallery.Management
{
    [Authorize(RetrohofPermissions.GalleryImage.Create)]
    public class CreateModalModel : PageModel
    {
        [BindProperty]
        public CreateUpdateGalleryImageDto Image { get; set; }

        private readonly IImageGalleryAppService _imageGalleryAppService;

        public CreateModalModel(IImageGalleryAppService imageGalleryAppService)
        {
            _imageGalleryAppService = imageGalleryAppService;
        }

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            await _imageGalleryAppService.CreateAsync(Image);
        }
    }
}
