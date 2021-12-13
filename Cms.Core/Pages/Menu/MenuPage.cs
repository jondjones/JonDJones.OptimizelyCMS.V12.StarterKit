using Cms.Core.Resouces;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cms.Core.Pages.Menu
{
    [ContentType(DisplayName = "Menu",
            GUID = "8b977a97-7cfd-4419-935d-37febcd7e7d2",
            Description = "Menu",
            GroupName = GlobalConstants.TabNames.Container)]
    [AvailableContentTypes(Include = new[] { typeof(MenuItem) })]
    [ImageUrl("/images/pic01.jpg")]
    public class MenuPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Menu Url",
            Description = "Menu Url",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual Url MenuContentPage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Menu Image",
            Description = "Menu Image",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MenuImageUrl { get; set; }
    }
}