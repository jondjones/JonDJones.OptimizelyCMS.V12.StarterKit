using Cms.Core.Resouces;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System.ComponentModel.DataAnnotations;

namespace Cms.Core.Pages.Menu
{
    [ContentType(DisplayName = "Menu Item",
            GUID = "399670e8-454e-4fd9-be85-6501030d971e",
            Description = "Menu Item",
            GroupName = GlobalConstants.TabNames.Container)]
    [ImageUrl("/images/pic01.jpg")]
    public class MenuItem : PageData
    {
        [Display(
            Name = "Menu Url",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [Required]
        public virtual Url MenuUrl { get; set; }

        [Display(
            Name = "Menu Icon",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual string MenuIcon { get; set; }

        [Display(Name = "Sub Links",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual LinkItemCollection SubLinks { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            MenuIcon = "icon fa-chart-bar";
        }
    }
}