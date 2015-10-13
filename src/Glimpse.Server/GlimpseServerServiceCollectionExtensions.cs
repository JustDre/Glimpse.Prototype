﻿using System;
using Glimpse.Server;
using Microsoft.Extensions.DependencyInjection;

namespace Glimpse
{
    public static class GlimpseServerServiceCollectionExtensions
    {
        public static GlimpseServerServiceCollectionBuilder RunningServerWeb(this GlimpseServiceCollectionBuilder services)
        {
            return services.RunningServerWeb(null);
        }

        public static GlimpseServerServiceCollectionBuilder RunningServerWeb(this GlimpseServiceCollectionBuilder services, Action<GlimpseServerOptions> setupAction)
        {
            services.AddOptions();
            
            services.AddServerServices();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }

            return new GlimpseServerServiceCollectionBuilder(services);
        }

        public static IServiceCollection WithLocalAgent(this GlimpseServerServiceCollectionBuilder services)
        { 
            return services.AddLocalAgentServices();
        }
    }
}