using Cms.Core.Pages.Menu;
using System.Collections.Generic;

namespace JonDJones.Core.ViewComponents
{
    public class HeaderViewModel
    {
        public IEnumerable<MenuItem> MenuItems { get; set; }
        public string Title { get; internal set; }
    }
}