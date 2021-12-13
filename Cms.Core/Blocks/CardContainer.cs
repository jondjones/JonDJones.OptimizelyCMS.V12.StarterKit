using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cms.Core.Resouces;
using EPiServer;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Blocks
{
    [ContentType(
        DisplayName = "Card Block",
        GUID = "a4d59fd8-b1b4-4b39-b99b-dd3fc30b0fb5",
        GroupName = GlobalConstants.GroupNames.Common)]
    [ImageUrl("/images/pic02.jpg")]
    public class CardContainerBlock : BlockData
    {
        [Display(
             Name = "Top Content",
             GroupName = SystemTabNames.Content,
             Order = 100)]
        public virtual XhtmlString Title { get; set; }

        [Display(
            Name = "Cards",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [AllowedTypes(typeof(CardItemBlock))]
        public virtual ContentArea Cards { get; set; }

        [Display(
            Name = "Cta Text",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string CtaTitle { get; set; }

        [Display(
            Name = "Url",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual Url Url { get; set; }

    }
}