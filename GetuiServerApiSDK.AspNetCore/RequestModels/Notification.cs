using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class Notification : NotificationBase
    {
        [JsonProperty(PropertyName = "big_text", NullValueHandling = NullValueHandling.Ignore)]
        public string BigText { get; set; }
        [JsonProperty(PropertyName = "big_image", NullValueHandling = NullValueHandling.Ignore)]
        public string BigImage { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }
        [JsonProperty(PropertyName = "logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoUrl { get; set; }
        [JsonProperty(PropertyName = "channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; }
        [JsonProperty(PropertyName = "channel_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelName { get; set; }
        [JsonProperty(PropertyName = "channel_level")]
        public int ChannelLevel { get; set; } = 3;
        
    }
}
