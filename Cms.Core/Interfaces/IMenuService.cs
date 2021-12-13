using Cms.Core.Pages.Menu;
using System.Collections.Generic;

namespace Cms.Core.Interfaces
{
    public interface IMenuService
    {
        IEnumerable<MenuItem> Menus { get; }
    }
}