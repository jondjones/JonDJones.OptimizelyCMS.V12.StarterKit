using Cms.Core.Models.Pages;
using Cms.Core.ViewModel;
using EPiServer.Web.Mvc;
using JonDJones.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Core.Controllers
{
    public class BLogPageController : PageController<BlogPage>
    {
        public IActionResult Index(BlogPage currentpage)
        {
            var viewModel = new ComposedPageViewModel<BlogPage, BlogPageViewModel>
            {
                Page = currentpage,
                ViewModel = new BlogPageViewModel
                {
                }
            };

            return View(viewModel);
        }
    }
}