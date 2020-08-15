using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Ios
{
    public class Ios
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Aps Aps { get; set; }
        public string AutoBadge { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }
        [JsonProperty(PropertyName = "multimedia", NullValueHandling = NullValueHandling.Ignore)]
        public MultiMedia MultiMedia { get; set; }
    }
}
