using Cms.Core.Interfaces;
using Cms.Core.Pages.Menu;
using EPiServer;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Core.Services
{
    public class MenuService : IMenuService
    {
        private IContentRepository _contentRepository;

        public MenuService(
            IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public IEnumerable<MenuItem> Menus => GetMenuItems();

        private IEnumerable<MenuItem> GetMenuItems()
        {
            var container = _contentRepository
                .GetChildren<MenuContainer>(ContentReference.RootPage)
                .FirstOrDefault();

            var headerMenu = _contentRepository
                .GetChildren<MenuPage>(container.ContentLink)
                .FirstOrDefault(y => y.Name.ToLower().Contains("header"));

            return _contentRepository.GetChildren<MenuItem>(headerMenu.ContentLink);
        }
    }
}