using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Cms.Core.Resouces
{

    public static class GlobalConstants
    {
        [GroupDefinitions]
        public static class TabNames
        {
            [Display(Order = 100)]
            public const string Container = "Container";

            [Display(Order = 200)]
            public const string Seo = "Seo";
        }

        public static class GroupNames
        {
            public const string Common = "Common";

            public const string Admin = "Admin";

            public const string Blog = "Blog";

        }
    }
}