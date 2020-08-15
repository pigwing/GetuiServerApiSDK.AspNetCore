using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public abstract class NotificationBase
    {
        public string Title { get; set; }
        public string Body { get; set; }
        [JsonProperty(PropertyName = "click_type")]
        public string ClickType { get; set; } = "none";
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Intent { get; set; }
        [JsonProperty(PropertyName = "url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }
        [JsonProperty(PropertyName = "notify_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotifyId { get; set; }
    }
}
