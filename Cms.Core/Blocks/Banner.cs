using System.ComponentModel.DataAnnotations;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Blocks
{
    [ContentType(
        DisplayName = "Banner",
        GUID = "0d1c8743-4d48-470f-8afb-7e62d84f6092",
        GroupName = GlobalConstants.GroupNames.Common)]
    [ImageUrl("/images/pic02.jpg")]
    public class BannerBlock : BlockData
    {
        [Display(
             Name = "Top Content",
             GroupName = SystemTabNames.Content,
             Order = 100)]
        public virtual string Title { get; set; }
    }
}