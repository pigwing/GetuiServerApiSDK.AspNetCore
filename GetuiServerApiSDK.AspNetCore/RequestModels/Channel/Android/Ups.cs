using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Android
{
    public class Ups
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Notification Notification { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Transmission { get; set; }
    }
}
