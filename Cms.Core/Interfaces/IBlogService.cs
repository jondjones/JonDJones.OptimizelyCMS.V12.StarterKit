using JonDJones.Core.ViewModel;
using System.Collections.Generic;

namespace Cms.Core.Interfaces
{
    public interface IBlogService
    {
        public IEnumerable<BlogPageViewModel> Blogs { get; }
    }
}
