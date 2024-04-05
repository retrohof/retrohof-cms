using System;
using Volo.Abp.Application.Dtos;

namespace Retrohof.GalleryImages.Dtos
{
    public class GalleryImageDto : CreationAuditedEntityDto<Guid>
    {
        public string Description { get; set; }
        public Guid CoverImageMediaId { get; set; }
    }
}
