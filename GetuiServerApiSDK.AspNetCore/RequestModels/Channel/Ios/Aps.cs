using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Ios
{
    public class Aps
    {
        public Alert Alert { get; set; }
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
