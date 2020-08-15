using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GetuiServerApiSDK.AspNetCore.GetuiResult;
using GetuiServerApiSDK.AspNetCore.Json;
using GetuiServerApiSDK.AspNetCore.RequestModels;
using Microsoft.Extensions.Logging;

namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public class AuthTokenService : ServiceBase
    {
        private readonly HttpClient _client;
        private readonly GetuiConfiguration _getuiConfiguration;

        private static readonly  ConcurrentDictionary<string, AuthTokenResult> Tokens = new ConcurrentDictionary<string, AuthTokenResult>();
        private static readonly ConcurrentDictionary<string, bool> PendingRefreshTokenRequests =
            new ConcurrentDictionary<string, bool>();

        private readonly ILogger _logger;

        private static string Sha256(string data)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public AuthTokenService(HttpClient client, GetuiConfiguration getuiConfiguration,
            ILogger<AuthTokenService> logger) : base(getuiConfiguration)
        {
            _client = client;
            _getuiConfiguration = getuiConfiguration;
            _client.BaseAddress = new Uri(Constants.Host);
            _client.Timeout = TimeSpan.FromSeconds(10);
            _logger = logger;
        }

        public async Task<AuthTokenResult> GetAuthToken()
        {

            string tokenKey = GetTokenKey();

            if (Tokens.TryGetValue(tokenKey, out AuthTokenResult getAuthTokenResult))
            {
                if (DateTime.UtcNow < getAuthTokenResult.Data.ExpireDateTime)
                {
                    return getAuthTokenResult;
                }
            }

            bool shouldRefresh = PendingRefreshTokenRequests.TryAdd(tokenKey, true);
            if (!shouldRefresh) return getAuthTokenResult;
            try
            {
                //utc timestamp
                long timestamp = Utc.GetTimestamp();

                AuthTokenModel authTokenModel = new AuthTokenModel()
                {
                    Sign = Sha256(
                        string.Concat(_getuiConfiguration.AppKey, timestamp, _getuiConfiguration.MasterSecret)),
                    Timestamp = timestamp,
                    AppKey = _getuiConfiguration.AppKey
                };
                string requestUri = string.Concat(_getuiConfiguration.ApiVersion, "/", _getuiConfiguration.AppId,
                    "/auth");
                HttpResponseMessage httpResponseMessage =
                    await _client.PostAsync(requestUri, new JsonContent(authTokenModel));
                getAuthTokenResult = await httpResponseMessage.GetResultAsync<AuthTokenResult>();
                getAuthTokenResult.ClientHttpStatusCode = httpResponseMessage.StatusCode;

                Tokens[tokenKey] = getAuthTokenResult;

                _logger.LogInformation($"get auth token: {getAuthTokenResult}");
            }
            finally
            {
                PendingRefreshTokenRequests.TryRemove(tokenKey, out _);
            }

            return getAuthTokenResult;
        }

        public async Task<ResultMessage> CloseAuth()
        {
            string tokenKey = GetTokenKey();

            if (Tokens.TryGetValue(tokenKey, out AuthTokenResult authTokenResult))
            {
                string requestUri = string.Concat(_getuiConfiguration.ApiVersion, "/", _getuiConfiguration.AppId, "/auth/", authTokenResult.Data.AuthToken);
                HttpResponseMessage httpResponseMessage = await _client.DeleteAsync(requestUri);
                ResultMessage resultMessage = await httpResponseMessage.GetResultAsync<ResultMessage>();

                _logger.LogInformation($"close auth token: {resultMessage}");

                return resultMessage;
            }

            return new ResultMessage { ClientHttpStatusCode = HttpStatusCode.OK, Msg = "auth token not found", Code = 1};

        }
    }
}
