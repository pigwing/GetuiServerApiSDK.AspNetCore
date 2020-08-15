using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Ios
{
    public class MultiMedia
    {
        public string Url { get; set; }
        public int Type { get; set; } = 1;
        [JsonProperty(PropertyName = "only_wifi")]
        public bool OnlyWifi { get; set; }
    }
}
