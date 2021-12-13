using Cms.Core.Interfaces;
using Cms.Core.Models.Blocks;
using Cms.Core.Models.Pages;
using Cms.Core.ViewModel.POCO;
using EPiServer;
using EPiServer.ContentApi.Core.Serialization;
using EPiServer.ContentApi.Core.Serialization.Internal;
using EPiServer.ContentApi.Core.Serialization.Models;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cms.Core.Blocks
{
    [ServiceConfiguration(typeof(IContentApiModelFilter), Lifecycle = ServiceInstanceScope.Singleton)]
    public class CustomContentApiModelFilter : ContentApiModelFilter<ContentApiModel>
    {
        IContentRepository _contentRepository;
        IEpsierverUrlService _urlServce;
        IContentTypeRepository _contentTypeRepository;
        IContentModelUsage _contentModelUsage;

        public CustomContentApiModelFilter(
            IContentRepository repo,
            IEpsierverUrlService urlServce,
            IContentTypeRepository contentTypeRepository,
            IContentModelUsage contentModelUsage)
        {
            _contentRepository = repo;
            _urlServce = urlServce;
            _contentTypeRepository = contentTypeRepository;
            _contentModelUsage = contentModelUsage;
        }

        public override void Filter(
            ContentApiModel contentApiModel,
            ConverterContext converterContext)
        {
            try
            {
                if (contentApiModel.ContentType.Contains("CardContainerBlock"))
                {
                    PopulateCardContainerBlock(contentApiModel);
                }
                else if (contentApiModel.ContentType.Contains("BlogArea"))
                {
                    PopulateBlogArea(contentApiModel);
                }

                contentApiModel.ExistingLanguages = null;
                contentApiModel.MasterLanguage = null;
                contentApiModel.ParentLink = null;
                contentApiModel.Language = null;
                contentApiModel.StartPublish = null;
                contentApiModel.StopPublish = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PopulateBlogArea(ContentApiModel contentApiModel)
        {
            var contentType = _contentTypeRepository.Load<BlogListingPage>();
            var blogListingPage = _contentModelUsage.ListContentOfContentType(contentType)?.FirstOrDefault();

            var pages = _contentRepository.GetChildren<BlogPage>(blogListingPage.ContentLink);

            var cardItems = new List<BlogOverviewPoco>();

            foreach (var item in pages)
            {
                cardItems.Add(new BlogOverviewPoco
                {
                    Title = item.Title,
                    SubTitle = item.SubTitle,
                    Content = item.Content.ToHtmlString(),
                    BlogImageUrl = _urlServce.GetPrimaryUrl() + UrlResolver.Current.GetUrl(item.BlogImage),
                    Url = item.ExternalURL
                });
            };

            contentApiModel.Properties.Add("blog", cardItems);
        }

        private void PopulateCardContainerBlock(ContentApiModel contentApiModel)
        {
            var cards = contentApiModel.Properties["Cards"] as ContentAreaPropertyModel;

            var cardItems = new List<CardItemBlockPoco>();
            foreach (var item in cards.Value)
            {
                var result = _contentRepository.Get<CardItemBlock>(new ContentReference(item.ContentLink.Id.Value));
                cardItems.Add(new CardItemBlockPoco
                {
                    Title = result.Title,
                    ImageUrl = _urlServce.GetPrimaryUrl() + UrlResolver.Current.GetUrl(result.CardImage),
                    Content = result.Content,
                    Url = UrlResolver.Current.GetUrl(result.Url.PathAndQuery)
                });
            }
            contentApiModel.Properties.Remove("Cards");
            contentApiModel.Properties.Add("items", cardItems);
        }
    }
}
