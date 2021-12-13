using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;

namespace Cms.Core.Pages.Menu
{
    [ContentType(DisplayName = "Menu Container",
            GUID = "4e53646d-e5a4-4404-b01c-12a9a1fccda6",
            Description = "A placeholder to help organise menus",
            GroupName = GlobalConstants.TabNames.Container)]
    [AvailableContentTypes(Include = new[] { typeof(MenuPage) })]
    [ImageUrl("/images/pic01.jpg")]
    public class MenuContainer : PageData
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            this[MetaDataProperties.PageChildOrderRule] = FilterSortOrder.Index;
        }
    }
}