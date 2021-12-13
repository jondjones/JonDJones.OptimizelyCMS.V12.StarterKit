using Cms.Core.Models.Blocks;
using Cms.Core.ViewModel.Base;
using Cms.Core.ViewModel.Blocks;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cms.Core.ViewComponents.Optizmiely
{
    public class ContactUsComponent : AsyncBlockComponent<ContactUsBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(ContactUsBlock currentContent)
        {
            var viewModel = new ComposedBlockViewModel<ContactUsBlock, ContactUsViewModel>
            {
                Block = currentContent,
                ViewModel = new ContactUsViewModel()
            };

            return await Task.FromResult(View(viewModel));
        }
    }
}
