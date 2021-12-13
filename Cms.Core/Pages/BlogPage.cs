using System.ComponentModel.DataAnnotations;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Cms.Core.Models.Pages
{
    [ContentType(
        DisplayName = "Blog Page",
        GUID = "3ff9fa70-fae2-40c9-a1cc-0f08e589f8ea",
        GroupName = GlobalConstants.GroupNames.Blog)]
    [ImageUrl("/images/pic01.jpg")]
    public class BlogPage : SeoMetaData
    {
        [Display(
             Name = "Title",
             GroupName = SystemTabNames.Content,
             Order = 50)]
        public virtual string Title { get; set; }

        [Display(
             Name = "Sub Title",
             GroupName = SystemTabNames.Content,
             Order = 100)]
        public virtual string SubTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "Content",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString Content { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Blog Image",
            Description = "Blog Image",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BlogImage { get; set; }
    }
}