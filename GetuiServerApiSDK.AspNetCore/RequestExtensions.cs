﻿using System.Net.Http;

namespace GetuiServerApiSDK.AspNetCore
{
    public static class RequestExtensions
    {
        public static void SetAuthToken(this HttpClient httpClient, string authToken)
        {
            httpClient.DefaultRequestHeaders.Remove(Constants.AuthToken);
            httpClient.DefaultRequestHeaders.Add(Constants.AuthToken, authToken);
        }
    }
}
