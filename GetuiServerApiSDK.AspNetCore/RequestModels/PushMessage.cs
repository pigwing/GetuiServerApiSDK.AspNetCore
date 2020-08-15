using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class PushMessage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Notification Notification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Transmission { get; set; }
    }
}
