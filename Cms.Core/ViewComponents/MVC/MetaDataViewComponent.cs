using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JonDJones.Core.ViewComponents
{
    public class MetaDataViewComponent : ViewComponent
    {
        private IPageRouteHelper _pageRouteHelper;
        private IContentRepository _contentRepository;

        public MetaDataViewComponent(
                IPageRouteHelper pageRouteHelper,
                IContentRepository contentRepository)
        {
            _pageRouteHelper = pageRouteHelper;
            _contentRepository = contentRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageReference = _pageRouteHelper.PageLink;
            var page = _contentRepository.Get<PageData>(pageReference);

            var metaData = new MetaDataViewModel
            {
                Title = page.Name
            };

            return View(metaData);
        }
    }
}