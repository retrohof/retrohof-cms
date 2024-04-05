using Retrohof.GalleryImages;
using Retrohof.GalleryImages.Dtos;
using Retrohof.Permissions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.CmsKit.Comments;
using Volo.CmsKit.Reactions;
using Microsoft.EntityFrameworkCore;

namespace Retrohof.Application
{
    public class ImageGalleryAppService :
        CrudAppService<GalleryImage, GalleryImageDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGalleryImageDto, CreateUpdateGalleryImageDto>,
        IImageGalleryAppService
    {
        public ImageGalleryAppService(IRepository<GalleryImage, Guid> repository) : base(repository)
        {
            CreatePolicyName = RetrohofPermissions.GalleryImage.Create;
            UpdatePolicyName = RetrohofPermissions.GalleryImage.Update;
            DeletePolicyName = RetrohofPermissions.GalleryImage.Delete;
        }

        public async Task<List<GalleryImageWithDetailsDto>> GetDetailedListAsync()
        {
            var dbContext = await Repository.GetDbContextAsync();

            var images = await (from image in dbContext.Set<GalleryImage>() 
                                select image).ToListAsync();

            return images.Select(x => new GalleryImageWithDetailsDto
            {
                Id = x.Id,
                Description = x.Description,
                CoverImageMediaId = x.CoverImageMediaId,

                CommentCount = (from comment in dbContext.Set<Comment>()
                                where comment.EntityType == Constant.ImageGalleryEntityType && comment.EntityId == x.Id.ToString()
                                select comment).Count(),

                LikeCount = (from reaction in dbContext.Set<UserReaction>()
                             where reaction.EntityType == Constant.ImageGalleryEntityType && reaction.EntityId == x.Id.ToString()
                             select reaction).Count()
            }).ToList();
        }
    }
}
