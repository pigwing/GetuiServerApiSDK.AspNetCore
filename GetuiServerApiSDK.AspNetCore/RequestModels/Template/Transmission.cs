using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class Transmission : ShowTimeBase
    {
        /// <summary>
        /// 收到消息是否立即启动应用，true为立即启动，false则广播等待启动，默认是否
        /// </summary>
        [JsonProperty(PropertyName = "transmission_type")]
        public bool TransmissionType { get; set; }
        /// <summary>
        /// 透传内容
        /// </summary>
        [JsonProperty(PropertyName = "transmission_content")]
        public string TransmissionContent { get; set; }
    }
}
