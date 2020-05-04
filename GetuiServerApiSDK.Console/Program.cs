using System;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore;
using GetuiServerApiSDK.AspNetCore.Clients;
using GetuiServerApiSDK.AspNetCore.GetuiResult;
using GetuiServerApiSDK.AspNetCore.RequestModels.Template;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GetuiServerApiSDK.Console
{
    class Program
    {
        private const string ClientId = "ee2c18ee96275846e8b534fbfcd5efcd";

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
                        AppId = "QCHfY2V8AZ99QCKnKsLy83",
                        AppKey = "McyGuR7tgkA46EBnxbm5W7",
                        MasterSecret = "1UfdYR8Ktn8WeDDtcH1FR4"
                    };
                    services.AddSingleton(getuiConfiguration);


                    services.AddServiceApi();
                }).UseConsoleLifetime();

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var authTokenService = services.GetRequiredService<AuthTokenService>();
                    var authTokenResult = await authTokenService.GetAuthToken();
                    
                    PushTemplateMessageService pushTemplateMessageService =
                        services.GetRequiredService<PushTemplateMessageService>();

                    PushResultMessage pushResultMessage;
                    pushResultMessage = await PushNotificationTemplateToSingle(pushTemplateMessageService);
                    pushResultMessage = await PushLinkTemplateToSingle(pushTemplateMessageService);
                    pushResultMessage = await PushNotyPopLoadTemplateToSingle(pushTemplateMessageService);
                    pushResultMessage = await PushNotyPopLoadTemplateToSingle(pushTemplateMessageService);
                    pushResultMessage = await PushTransmissionTemplateToSingle(pushTemplateMessageService);

                    ResultMessage resultMessage = await authTokenService.CloseAuth();

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


        private static async Task<PushResultMessage> PushNotificationTemplateToSingle(
            PushTemplateMessageService pushTemplateMessageService)
        {
            NotificationTemplateModel notificationTemplateModel = new NotificationTemplateModel();
            Style style = new Style
            {
                Title = "这个是标题",
                Text = "这个是内容",
                IsRing = true,
                IsVibrate = true,
                IsClearable = true
            };
            Notification notification = new Notification {Style = style, TransmissionContent = "这是透传内容", TransmissionType = true};
            notificationTemplateModel.Notification = notification;
            notificationTemplateModel.ClientId = ClientId;
            notificationTemplateModel.RequestId = Guid.NewGuid().ToString("N");
            PushResultMessage pushResultMessage = await pushTemplateMessageService.PushNotificationTemplateToSingleAsync(notificationTemplateModel);

            return pushResultMessage;
        }

        private static async Task<PushResultMessage> PushLinkTemplateToSingle(
            PushTemplateMessageService pushTemplateMessageService)
        {
            LinkTemplateModel linkTemplateModel = new LinkTemplateModel();
            Style style = new Style
            {
                Title = "这个是标题",
                Text = "这个是内容",
                IsRing = true,
                IsVibrate = true,
                IsClearable = true
            };
            Link link = new Link { Style = style, Url = "http://www.baidu.com" };
            linkTemplateModel.Link = link;
            linkTemplateModel.ClientId = ClientId;
            linkTemplateModel.RequestId = Guid.NewGuid().ToString("N");
            PushResultMessage pushResultMessage = await pushTemplateMessageService.PushLinkTemplateToSingleAsync(linkTemplateModel);

            return pushResultMessage;

        }

        private static async Task<PushResultMessage> PushNotyPopLoadTemplateToSingle(
            PushTemplateMessageService pushTemplateMessageService)
        {
            Style style = new Style
            {
                Title = "这个是标题",
                Text = "这个是内容",
                IsRing = true,
                IsVibrate = true,
                IsClearable = true,
                LogoUrl = "http://www-igexin.qiniudn.com/wp-content/uploads/2013/08/logo_getui1.png"
            };
            NotyPopLoad notyPopLoad = new NotyPopLoad
            {
                Style = style, 
                NotyIcon = "icon.png", 
                NotyTitle = "这个是通知标题",
                NotyContent = "这个是通知栏内容",
                PopTitle = "这个是弹框标题",
                PopContent = "这个是弹框内容",
                PopImage = "",
                PopLeftButton = "下载",
                PopRightButton = "取消",
                LoadTitle = "这个是下载标题",
                LoadIcon = "file://push.png",
                LoadUrl = "http://www.appchina.com/market/d/425201/cop.baidu_0/com.gexin.im.apk",
                IsActived = true
            };
            NotyPopLoadTemplateModel notyPopLoadTemplateModel = new NotyPopLoadTemplateModel();
            notyPopLoadTemplateModel.NotyPopLoad = notyPopLoad;
            notyPopLoadTemplateModel.ClientId = ClientId;
            notyPopLoadTemplateModel.RequestId = Guid.NewGuid().ToString("N");
            PushResultMessage pushResultMessage = await pushTemplateMessageService.PushNotyPopLoadTemplateToSingleAsync(notyPopLoadTemplateModel);

            return pushResultMessage;
        }

        private static async Task<PushResultMessage> PushStartActivityTemplateToSingle(
            PushTemplateMessageService pushTemplateMessageService)
        {
            StartActivityStyle style = new StartActivityStyle
            {
                Title = "这个是标题",
                Text = "这个是内容",
                IsRing = true,
                IsVibrate = true,
                IsClearable = true,
                LogoUrl = "http://www-igexin.qiniudn.com/wp-content/uploads/2013/08/logo_getui1.png",
                BigStyle = 1,
                BigImageUrl = "http://www-igexin.qiniudn.com/wp-content/uploads/2013/08/logo_getui1.png",
                Logo = "logo.png",
                ChannelLevel = 3
            };

            StartActivity startActivity = new StartActivity
                {Style = style, TransmissionContent = "这是透传内容", TransmissionType = true, Intent = "intent:#Intent;action=com.duowan.pushsdk.getui.CKLICK_NOTIFYMESSAGE;package=com.example.yypushsrvsdktest;component=com.example.yypushsrvsdktest/com.yy.pushsvc.impl.PushGTActivity;S.payload=abcdtest;end" };
            StartActivityTemplateModel startActivityTemplateModel = new StartActivityTemplateModel();
            startActivityTemplateModel.StartActivity = startActivity;
            startActivityTemplateModel.Style = style;
            startActivityTemplateModel.ClientId = ClientId;
            startActivityTemplateModel.RequestId = Guid.NewGuid().ToString("N");
            startActivityTemplateModel.Message.OfflineExpireTime = 345600000;
            startActivityTemplateModel.Message.PushNetWorkType = 0;
            PushResultMessage pushResultMessage = await pushTemplateMessageService.PushStartActivityTemplateToSingleAsync(startActivityTemplateModel);

            return pushResultMessage;
        }

        public static async Task<PushResultMessage> PushTransmissionTemplateToSingle(
            PushTemplateMessageService pushTemplateMessageService)
        {
            Transmission transmission = new Transmission()
            {
                TransmissionContent = "这个是透传内容",
                TransmissionType = true
            };
            //ios
            PushInfo pushInfo = new PushInfo()
            {
                Aps = new Aps()
                {
                    Alert = new Alert()
                    {
                        Title = "这个是通知标题",
                        Body = "这个是通知内容"
                    },
                    AutoBadge = "+1",
                    ContentAvailable = 1
                }
            };

            TransmissionTemplateModel transmissionTemplateModel = new TransmissionTemplateModel();
            transmissionTemplateModel.Transmission = transmission;
            transmissionTemplateModel.PushInfo = pushInfo;
            transmissionTemplateModel.ClientId = ClientId;
            transmissionTemplateModel.RequestId = Guid.NewGuid().ToString("N");
            PushResultMessage pushResultMessage = await pushTemplateMessageService.PushTransmissionTemplateToSingleAsync(transmissionTemplateModel);

            return pushResultMessage;
        }
    }
}
