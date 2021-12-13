using System.ComponentModel.DataAnnotations;
using Cms.Core.Models.Blocks;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Cms.Core.Models.Pages
{
    [Access(Roles = "Administrators")]
    [ContentType(
        DisplayName = "Settings Page",
        GUID = "5835D525-77D9-4F5F-BAB9-D0C14E273C15",
        Description = "Settings Page",
        GroupName = GlobalConstants.GroupNames.Admin)]
    [ImageUrl("/images/pic01.jpg")]
    public class SettingsPage : PageData
    {
        [Display(
            Name = "Footer Components",
            Description = "Footer Components",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [AllowedTypes(typeof(ContactUsBlock))]
        public virtual ContentArea Footer { get; set; }
    }
}