using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Cms.Core.Models.Blocks
{
    [ContentType(
        DisplayName = "Contact Us",
        GUID = "837aefd5-b843-4b3e-b341-153121c3f47c",
        GroupName = GlobalConstants.GroupNames.Common)]
    [ImageUrl("/images/pic02.jpg")]
    public class ContactUsBlock : BlockData
    {
    }
}