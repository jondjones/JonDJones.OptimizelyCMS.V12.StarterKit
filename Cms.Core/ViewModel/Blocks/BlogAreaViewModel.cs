using JonDJones.Core.ViewModel;
using System.Collections.Generic;

namespace Cms.Core.ViewModel.Blocks
{
    public class BlogAreaViewModel
    {
        public IEnumerable<BlogPageViewModel> Blogs { get; set; }
    }
}