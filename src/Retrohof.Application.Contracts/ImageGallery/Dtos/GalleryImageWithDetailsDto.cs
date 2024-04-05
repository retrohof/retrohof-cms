using System;
using Volo.Abp.Application.Dtos;

namespace Retrohof.GalleryImages.Dtos
{
    public class GalleryImageWithDetailsDto : EntityDto<Guid>
    {
        public string Description { get; set; }
        public Guid CoverImageMediaId { get; set; }

        public int LikeCount { get; set; }

        public int CommentCount { get; set; }
    }
}
