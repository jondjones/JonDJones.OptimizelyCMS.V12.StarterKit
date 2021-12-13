using System.ComponentModel.DataAnnotations;
using Cms.Core.Models.Blocks;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Pages
{
    [ContentType(
        DisplayName = "Blog Listing Page",
        GUID = "95bc1189-404f-4411-8e80-2ce7148aef70",
        GroupName = GlobalConstants.GroupNames.Blog)]
    [ImageUrl("/images/pic01.jpg")]
    [AvailableContentTypes(Include = new[] { typeof(BlogPage) })]
    public class BlogListingPage : SeoMetaData
    {
    }
}