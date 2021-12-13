using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Blocks
{
    [ContentType(
        DisplayName = "Blog Area",
        GUID = "d2ee7891-06a1-4ac6-ad62-a183fab392cb",
        GroupName = GlobalConstants.GroupNames.Common)]
    [ImageUrl("/images/pic02.jpg")]
    public class BlogArea : BlockData
    {
    }
}