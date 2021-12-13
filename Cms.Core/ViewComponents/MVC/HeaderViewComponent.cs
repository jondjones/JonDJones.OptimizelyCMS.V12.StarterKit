using Cms.Core.Interfaces;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JonDJones.Core.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private IMenuService _menu;
        private IPageRouteHelper _pageRouteHelper;
        private IContentRepository _contentRepository;

        public HeaderViewComponent(
                IMenuService menu,
                IPageRouteHelper pageRouteHelper,
                IContentRepository contentRepository)
        {
            _menu = menu;
            _pageRouteHelper = pageRouteHelper;
            _contentRepository = contentRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageReference = _pageRouteHelper.PageLink;
            var page = _contentRepository.Get<PageData>(pageReference);

            var header = new HeaderViewModel
            {
                MenuItems = _menu.Menus,
                Title = page.Name
            };

            return View(header);
        }
    }
}