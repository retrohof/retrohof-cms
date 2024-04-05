using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Retrohof.GalleryImages;
using Retrohof.GalleryImages.Dtos;
using System;
using System.Threading.Tasks;

namespace CmsKitDemo.Pages.Gallery
{
    public class DetailModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        public GalleryImageDto Image { get; set; }

        private readonly IImageGalleryAppService _imageGalleryAppService;

        public DetailModel(IImageGalleryAppService imageGalleryAppService)
        {
            _imageGalleryAppService = imageGalleryAppService;
        }

        public async Task OnGetAsync()
        {
            Image = await _imageGalleryAppService.GetAsync(Id);
        }
    }
}
