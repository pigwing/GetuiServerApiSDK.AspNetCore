using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class Strategy
    {
        public int Default { get; set; } = 1;
        [JsonProperty(PropertyName = "ios")]
        public int IOS { get; set; } = 1;
        [JsonProperty(PropertyName = "st")]
        public int SmarTisan { get; set; } = 1;
        [JsonProperty(PropertyName = "hw")]
        public int HuaWei { get; set; } = 1;
        [JsonProperty(PropertyName = "xm")]
        public int XiaoMi { get; set; } = 1;
        [JsonProperty(PropertyName = "vv")]
        public int Vivo { get; set; } = 1;
        [JsonProperty(PropertyName = "mz")]
        public int MeiZu { get; set; } = 1;
        [JsonProperty(PropertyName = "op")]
        public int Oppo { get; set; } = 1;
    }
}
