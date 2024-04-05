using Retrohof.GalleryImages.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Retrohof.GalleryImages
{
    public interface IImageGalleryAppService : ICrudAppService<GalleryImageDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGalleryImageDto, CreateUpdateGalleryImageDto>
    {
        Task<List<GalleryImageWithDetailsDto>> GetDetailedListAsync();
    }
}
