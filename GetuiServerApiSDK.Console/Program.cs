using System;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore;
using GetuiServerApiSDK.AspNetCore.Clients;
using GetuiServerApiSDK.AspNetCore.GetuiResult;
using GetuiServerApiSDK.AspNetCore.RequestModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GetuiServerApiSDK.Console
{
    class Program
    {
        private const string ClientId = "";

        static async Task<int> Main(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    GetuiConfiguration getuiConfiguration = new GetuiConfiguration()
                    {
                        AppId = "",
                        AppKey = "",
                        MasterSecret = "",
                        ApiVersion = "v2"
                    };
                    services.AddSingleton(getuiConfiguration);


                    services.AddGetuiServiceApi();
                }).UseConsoleLifetime();

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var authTokenService = services.GetRequiredService<AuthTokenService>();
                    var pushCommonMessageService = services.GetRequiredService<PushCommonMessageService>();
                    var authTokenResult = await authTokenService.GetAuthToken();

                    PushResultMessage pushResultMessage = null;
                    //pushResultMessage = await PushSingleNotificationClientId(pushCommonMessageService);
                    pushResultMessage = await PushSingleTransmissionClientId(pushCommonMessageService);


                    ResultMessage resultMessage = await authTokenService.CloseAuth();


                    //ResultMessage resultMessage = await authTokenService.CloseAuth();

                    System.Console.ReadLine();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();

                    logger.LogError(ex, "An error occurred.");
                }
            }

            return 0;
        }

        private static async Task<PushResultMessage> PushSingleNotificationClientId(PushCommonMessageService pushCommonMessageService)
        {
            CommonMessage commonMessage = CommonMessageGenerator.PushSingleClientIdNotificationBase(ClientId, "这是标题", "这是内容");
            return await pushCommonMessageService.PushSingleClientId(commonMessage);

        }

        private static async Task<PushResultMessage> PushSingleTransmissionClientId(
            PushCommonMessageService pushCommonMessageService)
        {
            CommonMessage commonMessage = CommonMessageGenerator.PushSingleClientIdTransmissionBase(ClientId, @"{""title"": ""这是标题"", ""body"": ""这是内容: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + @"""}");
            return await pushCommonMessageService.PushSingleClientId(commonMessage);
        }


    }
}
