using EPiServer;
using EPiServer.Core;

namespace Cms.Core.Blocks
{
    internal class CardItemBlockPoco
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public XhtmlString Content { get; set; }

        public string Url { get; set; }
    }
}