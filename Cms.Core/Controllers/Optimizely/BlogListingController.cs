using Cms.Core.Models.Pages;
using Cms.Core.ViewModel;
using EPiServer.Web.Mvc;
using JonDJones.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Core.Controllers
{
    public class BlogListingPageController : PageController<BlogListingPage>
    {
        public IActionResult Index(BlogListingPage currentpage)
        {
            var viewModel = new ComposedPageViewModel<BlogListingPage, BLogListingViewModel>
            {
                Page = currentpage,
                ViewModel = new BLogListingViewModel
                {
                }
            };

            return View(viewModel);
        }
    }
}