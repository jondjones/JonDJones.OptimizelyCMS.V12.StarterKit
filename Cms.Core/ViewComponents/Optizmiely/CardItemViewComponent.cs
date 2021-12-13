using Cms.Core.Models.Blocks;
using Cms.Core.ViewModel.Base;
using Cms.Core.ViewModel.Blocks;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cms.Core.ViewComponents.Optizmiely
{
    public class CardItemComponent : AsyncBlockComponent<CardItemBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(CardItemBlock currentContent)
        {
            var viewModel = new ComposedBlockViewModel<CardItemBlock, CardItemViewModel>
            {
                Block = currentContent,
                ViewModel = new CardItemViewModel
                {
                    Title = currentContent.Title,
                    Content = currentContent.Content,
                    ImageUrl = UrlResolver.Current.GetUrl(currentContent.CardImage),
                    Url = currentContent.Url
                }
            };

            return await Task.FromResult(View(viewModel));
        }
    }
}