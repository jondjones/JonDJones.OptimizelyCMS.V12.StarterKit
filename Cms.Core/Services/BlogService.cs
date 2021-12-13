using Cms.Core.Interfaces;
using Cms.Core.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using JonDJones.Core.ViewModel;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Core.Services
{
    public class BlogService : IBlogService
    {
        private IContentRepository _contentRepository;

        public BlogService(
            IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public IEnumerable<BlogPageViewModel> Blogs => GetBlogs();

        private IEnumerable<BlogPageViewModel> GetBlogs()
        {
            var blogListing = _contentRepository
                .GetChildren<BlogListingPage>(ContentReference.StartPage)
                .FirstOrDefault();

            if (blogListing == null)
            {
                return Enumerable.Empty<BlogPageViewModel>();
            }

            return _contentRepository
                .GetChildren<BlogPage>(blogListing.ContentLink)
                .Select(ConvertToBlogItemViewModel);
        }

        private BlogPageViewModel ConvertToBlogItemViewModel(BlogPage blog)
        {
            return new BlogPageViewModel
            {
                Title = blog.Title,
                ImageUrl = UrlResolver.Current.GetUrl(blog.BlogImage),
                LinkUrl = blog.LinkURL,
                Content = blog.Content
            };
        }
    }
}
