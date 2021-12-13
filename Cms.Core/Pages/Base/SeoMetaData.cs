using System.ComponentModel.DataAnnotations;
using Cms.Core.Resouces;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Cms.Core.Models.Pages
{
    public class SeoMetaData : PageData
    {
        [Display(
             Name = "MetaDescrption",
             GroupName = GlobalConstants.TabNames.Seo,
             Order = 50)]
        public virtual string MetaDescrption { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            MetaDescrption = "A responsive HTML5 site template. Manufactured by HTML5 UP.";
        }

    }
}