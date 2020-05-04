using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 点开通知打开应用模板
    /// </summary>
    public class Notification : ShowTimeBase
    {
        /// <summary>
        /// 通知栏消息布局样式
        /// </summary>
        public Style Style { get; set; }
        /// <summary>
        /// 收到消息是否立即启动应用，true为立即启动，false则广播等待启动，默认是否
        /// </summary>

        [JsonProperty(PropertyName = "transmission_type")]
        public bool TransmissionType { get; set; }
        /// <summary>
        /// 透传内容
        /// </summary>

        [JsonProperty(PropertyName = "transmission_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TransmissionContent { get; set; }
    }
}
