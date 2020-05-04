using GetuiServerApiSDK.AspNetCore.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace GetuiServerApiSDK.AspNetCore
{
    public static class ResponseExtensions
    {
        public static async Task<T> GetResultAsync<T>(this HttpResponseMessage httpResponseMessage)
        {
            string contentString = await httpResponseMessage.Content.ReadAsStringAsync();
            return contentString.FromJson<T>();
        }
    }
}
