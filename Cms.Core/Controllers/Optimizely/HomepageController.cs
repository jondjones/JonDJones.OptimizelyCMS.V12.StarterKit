using Cms.Core.Interfaces;
using Cms.Core.Models.Pages;
using Cms.Core.ViewModel;
using EPiServer.Web.Mvc;
using JonDJones.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Core.Controllers
{
    public class HomepageController : PageController<HomePage>
    {
        public IActionResult Index(HomePage currentpage)
        {
            var viewModel = new ComposedPageViewModel<HomePage, HomeViewModel>
            {
                Page = currentpage,
                ViewModel = new HomeViewModel
                {
                }
            };

            return View(viewModel);
        }
    }
}