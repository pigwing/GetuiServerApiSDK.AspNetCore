using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore.GetuiResult;
using GetuiServerApiSDK.AspNetCore.Json;
using GetuiServerApiSDK.AspNetCore.RequestModels;
using Microsoft.Extensions.Logging;

namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public class PushCommonMessageService
    {
        private readonly AuthTokenService _authTokenService;
        private readonly HttpClient _client;
        private readonly ILogger _logger;
        private readonly string _requestUri;

        public PushCommonMessageService(GetuiConfiguration getuiConfiguration, AuthTokenService authTokenService, HttpClient client, ILogger<PushCommonMessageService> logger)
        {
            _authTokenService = authTokenService;
            _client = client;
            _client.BaseAddress = new Uri(Constants.Host);
            _logger = logger;
            _requestUri = string.Concat(getuiConfiguration.ApiVersion, "/", getuiConfiguration.AppId);
        }

        private async Task<PushResultMessage> Push(string requestUri, CommonMessage commonMessage)
        {
            AuthTokenResult authTokenResult = await _authTokenService.GetAuthToken();
            if (authTokenResult == null)
                return new PushResultMessage()
                    { ClientHttpStatusCode = HttpStatusCode.BadRequest, Msg = "auth token is null", Code = 1 };

            _client.SetAuthToken(authTokenResult.Data.AuthToken);
            HttpResponseMessage httpResponseMessage =
                await _client.PostAsync(requestUri, new JsonContent(commonMessage));
            PushResultMessage pushResultMessage = await httpResponseMessage.GetResultAsync<PushResultMessage>();

            _logger.LogInformation($"push result: {pushResultMessage}");
            return pushResultMessage;
        }

        public async Task<PushResultMessage> PushSingleClientId(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/single/cid");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushSingleAlias(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/single/alias");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushSingleBatchClientId(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/single/batch/cid");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushSingleBatchAlias(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/single/batch/alias");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushListMessage(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/list/message");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushListClientId(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/list/cid");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushListAlias(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/list/alias");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushAll(CommonMessage commonMessage)
        {
            commonMessage.Audience = "all";
            string requestUri = string.Concat(_requestUri, "/push/all");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushTag(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/all");
            return await Push(requestUri, commonMessage);
        }

        public async Task<PushResultMessage> PushFastCustomTag(CommonMessage commonMessage)
        {
            string requestUri = string.Concat(_requestUri, "/push/fast_custom_tag");
            return await Push(requestUri, commonMessage);
        }
    }
}
