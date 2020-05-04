using System;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore.Clients;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GetuiServerApiSDK.AspNetCore
{
    public static class ApiBuildExtensions
    {
        public static IApplicationBuilder UseGetuiServiceApi(this IApplicationBuilder applicationBuilder,
            IServiceProvider serviceProvider)
        {
            AuthTokenService authTokenService = serviceProvider.GetService<AuthTokenService>();
            GetuiConfiguration getuiConfiguration = serviceProvider.GetService<GetuiConfiguration>();
            if(getuiConfiguration == null)
                throw new ArgumentNullException(nameof(GetuiConfiguration));
            //提前获取auto token防止启动时候的并发发送
            Task.Run(async () =>
            {
                await authTokenService.GetAuthToken();
            });
            

            return applicationBuilder;
        }
    }
}
