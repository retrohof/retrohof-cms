using JetBrains.Annotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Retrohof.GalleryImages.Dtos
{
	public class CreateUpdateGalleryImageDto
    {
        [NotNull]
        [StringLength(Constant.MaxDescriptionLength)]
        public string Description { get; set; }

        public Guid CoverImageMediaId { get; set; }
    }
}
