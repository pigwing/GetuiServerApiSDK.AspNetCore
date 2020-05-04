using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public abstract class TemplateBase
    {
        [JsonProperty(PropertyName = "cid")]
        public string ClientId { get; set; }
        [JsonProperty(PropertyName = "requestid")]
        public string RequestId { get; set; }
        public Message Message { get; protected set; }
    }
}
