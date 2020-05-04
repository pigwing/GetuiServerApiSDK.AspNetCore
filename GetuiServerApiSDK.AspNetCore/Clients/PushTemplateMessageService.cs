using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore.GetuiResult;
using GetuiServerApiSDK.AspNetCore.Json;
using GetuiServerApiSDK.AspNetCore.RequestModels.Template;
using Microsoft.Extensions.Logging;

namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public class PushTemplateMessageService : ServiceBase
    {
        private readonly GetuiConfiguration _getuiConfiguration;
        private readonly AuthTokenService _authTokenService;
        private readonly HttpClient _client;
        private readonly string _requestUri;
        private readonly ILogger _logger;
        public PushTemplateMessageService(GetuiConfiguration getuiConfiguration, AuthTokenService authTokenService, HttpClient client, ILogger<PushTemplateMessageService> logger) : base(getuiConfiguration)
        {
            _getuiConfiguration = getuiConfiguration;
            _authTokenService = authTokenService;
            _client = client;
            _client.BaseAddress = new Uri(Constants.Host);
            _client.Timeout = TimeSpan.FromSeconds(10);
            _requestUri = string.Concat(_getuiConfiguration.ApiVersion, "/", _getuiConfiguration.AppId, "/push_single");
            _logger = logger;
        }

        private async Task<PushResultMessage> PushTemplateToSingleAsync(TemplateBase template)
        {
            AuthTokenResult authTokenResult = await _authTokenService.GetAuthToken();
            if (authTokenResult == null)
                return new PushResultMessage()
                    { ClientHttpStatusCode = HttpStatusCode.BadRequest, Desc = "auth token is null" };

            template.Message.AppKey = _getuiConfiguration.AppKey;
            _client.SetAuthToken(authTokenResult.AuthToken);
            HttpResponseMessage httpResponseMessage =
                await _client.PostAsync(_requestUri, new JsonContent(template));
            PushResultMessage pushResultMessage = await httpResponseMessage.GetResultAsync<PushResultMessage>();

            _logger.LogInformation($"push result: {pushResultMessage}");
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushNotificationTemplateToSingleAsync(
            NotificationTemplateModel notificationTemplateModel)
        {
            PushResultMessage pushResultMessage = await PushTemplateToSingleAsync(notificationTemplateModel);
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushLinkTemplateToSingleAsync(LinkTemplateModel linkTemplateModel)
        {
            PushResultMessage pushResultMessage = await PushTemplateToSingleAsync(linkTemplateModel);
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushNotyPopLoadTemplateToSingleAsync(
            NotyPopLoadTemplateModel notyPopLoadTemplateModel)
        {
            PushResultMessage pushResultMessage = await PushTemplateToSingleAsync(notyPopLoadTemplateModel);
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushStartActivityTemplateToSingleAsync(
            StartActivityTemplateModel startActivityTemplateModel)
        {
            PushResultMessage pushResultMessage = await PushTemplateToSingleAsync(startActivityTemplateModel);
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushTransmissionTemplateToSingleAsync(
            TransmissionTemplateModel transmissionTemplateModel)
        {
            PushResultMessage pushResultMessage = await PushTemplateToSingleAsync(transmissionTemplateModel);
            return pushResultMessage;
        }
    }
}
