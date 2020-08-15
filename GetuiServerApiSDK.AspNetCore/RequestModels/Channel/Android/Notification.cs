using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Android
{
    public class Notification : NotificationBase
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Option[] Options { get; set; }
    }
}
