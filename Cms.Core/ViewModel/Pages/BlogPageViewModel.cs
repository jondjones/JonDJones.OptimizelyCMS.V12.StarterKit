using EPiServer.Core;
using Microsoft.AspNetCore.Html;

namespace JonDJones.Core.ViewModel
{
    public class BlogPageViewModel
    {
        public XhtmlString Content { get; set; }

        public string ImageUrl { get; set; }

        public string LinkUrl { get; set; }

        public string Title { get; set; }
    }
}