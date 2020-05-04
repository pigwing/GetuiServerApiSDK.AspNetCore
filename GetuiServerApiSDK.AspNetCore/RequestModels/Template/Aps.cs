using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class Aps
    {
        public Alert Alert { get; set; }
        /// <summary>
        /// 用于计算icon上显示的数字，还可以实现显示数字的自动增减，如“+1”、 “-1”、 “1” 等，计算结果将覆盖badge
        /// </summary>
        public string AutoBadge { get; set; }
        /// <summary>
        /// 通知铃声文件名，无声设置为“com.gexin.ios.silence”
        /// </summary>
        public string Sound { get; set; } = "com.gexin.ios.silence";
        [JsonProperty(PropertyName = "content-available")]
        public int ContentAvailable { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }
    }
}
