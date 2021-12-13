using EPiServer.Core;

namespace Cms.Core.ViewModel
{
    public class ComposedPageViewModel<TPage, TViewModel>
           where TPage : PageData
    {
        public TPage Page { get; set; }

        public TViewModel ViewModel { get; set; }
    }
}