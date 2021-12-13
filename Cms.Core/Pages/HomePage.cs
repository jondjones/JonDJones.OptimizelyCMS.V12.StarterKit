using System.ComponentModel.DataAnnotations;
using Cms.Core.Models.Blocks;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Pages
{
    [ContentType(
        DisplayName = "Home Page",
        GUID = "F4F8CD6F-28E0-4009-B32F-A77F90473CC6",
        GroupName = GlobalConstants.GroupNames.Common)]
    [AvailableContentTypes(Include = new[] { typeof(BlogListingPage) })]
    [ImageUrl("/images/pic01.jpg")]
    public class HomePage : SeoMetaData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(typeof(BannerBlock), typeof(CardContainerBlock), typeof(BlogArea))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}