using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class Audience
    {
        [JsonProperty(PropertyName = "cid")]
        public string[] ClientId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] Alias { get; set; }
        [JsonProperty(PropertyName = "fast_custom_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string FastCustomTag { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Tag Tag { get; set; }

    }
}
