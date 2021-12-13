using Cms.Core.Interfaces;
using Cms.Core.Models.Pages;
using EPiServer;
using EPiServer.Core;
using System.Linq;

namespace Cms.Core.Services
{
    public class SettingsService : ISettingsService
    {
        private IContentRepository _contentRepository;

        public SettingsService(
            IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public SettingsPage SettingsPage => GetSettings();

        private SettingsPage GetSettings()
        {
            return _contentRepository
                .GetChildren<SettingsPage>(ContentReference.RootPage)
                .FirstOrDefault();
        }
    }
}