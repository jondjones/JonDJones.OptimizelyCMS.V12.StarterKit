using Cms.Core.Models.Blocks;
using Cms.Core.ViewModel.Base;
using Cms.Core.ViewModel.Blocks;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cms.Core.ViewComponents.Optizmiely
{
    public class CardContainerComponent : AsyncBlockComponent<CardContainerBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(CardContainerBlock currentContent)
        {
            var viewModel = new ComposedBlockViewModel<CardContainerBlock, CardContainerViewModel>
            {
                Block = currentContent,
                ViewModel = new CardContainerViewModel
                {
                    CardArea = currentContent.Cards,
                    Title = currentContent.Title
                }
            };

            return await Task.FromResult(View(viewModel));
        }
    }
}