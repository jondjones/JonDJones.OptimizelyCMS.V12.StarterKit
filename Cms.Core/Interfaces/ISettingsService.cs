using Cms.Core.Models.Pages;

namespace Cms.Core.Interfaces
{
    public interface ISettingsService
    {
        SettingsPage SettingsPage { get; }
    }
}