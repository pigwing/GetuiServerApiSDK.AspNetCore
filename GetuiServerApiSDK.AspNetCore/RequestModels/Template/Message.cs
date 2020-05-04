using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 消息
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 注册应用时生成的appkey
        /// </summary>
        [JsonProperty(PropertyName = "appkey")]
        public string AppKey { get; set; }
        /// <summary>
        /// 是否离线推送
        /// </summary>
        [JsonProperty(PropertyName = "is_offline")]
        public bool IsOffline { get; set; }
        /// <summary>
        /// 消息应用类型，
        /// 可选项：notification、link、notypopload、startactivity, transmission
        /// </summary>
        [JsonProperty(PropertyName = "msgtype")]
        public string MsgType { get; set; }
        /// <summary>
        /// 消息离线存储有效期，单位：ms
        /// </summary>
        [JsonProperty(PropertyName = "offline_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OfflineExpireTime { get; set; }
        /// <summary>
        /// 选择推送消息使用网络类型，0：不限制，1：wifi
        /// </summary>
        [JsonProperty(PropertyName = "push_network_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PushNetWorkType { get; set; }


    }
}
