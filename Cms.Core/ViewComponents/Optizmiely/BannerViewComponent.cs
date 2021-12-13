using Cms.Core.Models.Blocks;
using Cms.Core.ViewModel.Base;
using Cms.Core.ViewModel.Blocks;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cms.Core.ViewComponents.Optizmiely
{
    public class BannerComponent : AsyncBlockComponent<BannerBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(BannerBlock currentContent)
        {
            var viewModel = new ComposedBlockViewModel<BannerBlock, BannerViewModel>
            {
                Block = currentContent,
                ViewModel = new BannerViewModel
                {
                    BannerText = currentContent.Title
                }
            };

            return await Task.FromResult(View(viewModel));
        }
    }
}
