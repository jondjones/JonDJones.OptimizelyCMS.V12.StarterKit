using System.ComponentModel.DataAnnotations;
using Cms.Core.Resouces;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Cms.Core.Models.Blocks
{
    [ContentType(
        DisplayName = "Card Item",
        GUID = "61d17c72-6663-48d8-b0a1-f5bf393368e0",
        GroupName = GlobalConstants.GroupNames.Common)]
    [ImageUrl("/images/pic02.jpg")]
    public class CardItemBlock : BlockData
    {
        [Display(
            Name = "Title",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Main Content",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString Content { get; set; }

        [UIHint(UIHint.Image)]
        [Display(
            Name = "Card image",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ContentReference CardImage { get; set; }

        [Display(
            Name = "Url",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual Url Url { get; set; }
    }
}