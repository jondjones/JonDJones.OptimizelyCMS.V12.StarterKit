using Cms.Core.Interfaces;
using Cms.Core.Models.Blocks;
using Cms.Core.ViewModel.Base;
using Cms.Core.ViewModel.Blocks;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cms.Core.ViewComponents.Optizmiely
{
    public class BlogAreaComponent : AsyncBlockComponent<BlogArea>
    {
        private IBlogService _blogService;

        public BlogAreaComponent(
                IBlogService blogService)
        {
            _blogService = blogService;
        }


        protected override async Task<IViewComponentResult> InvokeComponentAsync(BlogArea currentContent)
        {
            var viewModel = new ComposedBlockViewModel<BlogArea, BlogAreaViewModel>
            {
                Block = currentContent,
                ViewModel = new BlogAreaViewModel
                {
                    Blogs = _blogService.Blogs
                }
            };

            return await Task.FromResult(View(viewModel));
        }
    }
}
