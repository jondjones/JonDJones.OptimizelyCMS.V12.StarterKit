using EPiServer;
using EPiServer.Core;

namespace Cms.Core.ViewModel.Blocks
{
    public class CardItemViewModel
    {
        public string Title { get; set; }

        public XhtmlString Content { get; set; }

        public string ImageUrl { get; set; }

        public Url Url { get; set; }
    }
}