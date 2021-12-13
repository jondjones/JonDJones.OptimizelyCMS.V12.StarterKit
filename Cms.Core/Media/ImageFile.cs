using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Cms.Core.Models.Media
{
    [ContentType(
        DisplayName = "ImageFile",
        GUID = "D3922A4A-2DD2-442E-8CFF-ABF813289F61")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,gif,png")]
    public class ImageFile : ImageData
    {
    }
}