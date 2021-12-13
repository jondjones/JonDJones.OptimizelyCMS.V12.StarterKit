using Cms.Core.Interfaces;
using Cms.Core.Services;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cms.Core.InitialisationModule
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    public class DependencyInjection : IConfigurableModule
    {
        void IInitializableModule.Initialize(InitializationEngine context)
        {
        }

        private void ContextOnInitComplete(object sender, EventArgs e)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<ISettingsService, SettingsService>();
            context.Services.AddTransient<IMenuService, MenuService>();
            context.Services.AddTransient<IBlogService, BlogService>();
            context.Services.AddTransient<IEpsierverUrlService, EpsierverUrlService>();
        }

        void IInitializableModule.Uninitialize(InitializationEngine context)
        {
        }
    }
}