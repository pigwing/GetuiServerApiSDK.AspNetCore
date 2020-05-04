using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class AuthTokenModel
    {
        public string Sign { get; set; }
        public long Timestamp { get; set; }
        [JsonProperty(PropertyName = "appkey")]
        public string AppKey { get; set; }
    }
}
