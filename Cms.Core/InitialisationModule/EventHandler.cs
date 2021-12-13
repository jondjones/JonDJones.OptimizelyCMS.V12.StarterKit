using EPiServer;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Logging;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Cms.Core.InitialisationModule
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    public class EventHandler : IConfigurableModule
    {
        private List<string> WEBHOOK_URL = new List<string> {
            "https://api.cloudflare.com/client/v4/pages/webhooks/deploy_hooks/aff1d512-5404-4b0a-97e5-4bcbfc5e04e1",
            "https://api.netlify.com/build_hooks/61e0302bce44558499900bad"
            };

        private IServiceProvider _locator;

        void IInitializableModule.Initialize(InitializationEngine context)
        {
            _locator = context.Locate.Advanced;
            context.InitComplete += ContextOnInitComplete;
        }

        private void ContextOnInitComplete(object sender, EventArgs e)
        {
            _locator.GetInstance<IContentEvents>().PublishedContent += OnPublishedContent;
        }

        private void OnPublishedContent(object sender, ContentEventArgs e)
        {
            try
            {
                var client = new HttpClient();
                foreach (var url in WEBHOOK_URL)
                {
                    client.BaseAddress = new Uri(url);

                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("", "")
                    });


                        var response = client.PostAsync(string.Empty, content).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            LogManager.GetLogger(GetType()).Information("Called Webhook");
                        }
                        else
                        {
                            LogManager.GetLogger(GetType()).Error("Fail To Call Webhook");
                        }
                }
                client.Dispose();
            }
            catch (Exception)
            {
                LogManager.GetLogger(GetType()).Error("Fail To Call Webhook");
            }
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
        }

        void IInitializableModule.Uninitialize(InitializationEngine context)
        {
        }
    }
}