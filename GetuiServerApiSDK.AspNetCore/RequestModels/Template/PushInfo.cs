using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class PushInfo
    {
        public Aps Aps { get; set; }
        /// <summary>
        /// 增加自定义的数据
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public string PayLoad { get; set; }
        [JsonProperty(PropertyName = "multimedia")]
        public MultiMedia MultiMedia { get; set; }

    }
}
