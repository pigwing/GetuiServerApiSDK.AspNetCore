using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 透传消息模板
    /// </summary>
    public class TransmissionTemplateModel : TemplateBase
    {
        public TransmissionTemplateModel(bool isOffline = false)
        {
            Message = new Message {MsgType = "transmission", IsOffline = isOffline};
        }
        public Transmission Transmission { get; set; }
        [JsonProperty(PropertyName = "push_info", NullValueHandling = NullValueHandling.Ignore)]
        public PushInfo PushInfo { get; set; }
    }
}
