﻿using System;
using System.Collections.Generic;
using System.Text;
using GetuiServerApiSDK.AspNetCore.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace GetuiServerApiSDK.AspNetCore
{
    public static class ApiServiceExtensions
    {
        private static IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddHttpClient<AuthTokenService>();
            services.AddHttpClient<PushCommonMessageService>();

            return services;
        }

        public static IServiceCollection AddGetuiServiceApi(this IServiceCollection services)
        {
            AddServices(services);
            return services;
        }
    }
}
