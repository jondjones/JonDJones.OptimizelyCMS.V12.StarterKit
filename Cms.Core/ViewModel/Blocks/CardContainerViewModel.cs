using EPiServer.Core;

namespace Cms.Core.ViewModel.Blocks
{
    public class CardContainerViewModel
    {
        public ContentArea CardArea { get; set; }

        public XhtmlString Title { get; set; }
    }
}