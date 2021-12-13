using Cms.Core.ViewModel.Blocks;
using System.Collections.Generic;

namespace JonDJones.Core.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<BlogPageViewModel> Blogs { get; internal set; }
    }
}