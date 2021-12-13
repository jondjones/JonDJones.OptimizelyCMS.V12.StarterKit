namespace Cms.Core.ViewModel.POCO
{
    public class BlogOverviewPoco
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public string BlogImageUrl { get; set; }
        public string Url { get; internal set; }
    }
}