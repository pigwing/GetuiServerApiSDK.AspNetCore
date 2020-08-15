using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class CommonMessage
    {
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; } = Guid.NewGuid().ToString("N");

        public object Audience { get; set; } = "all";
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Setting Settings { get; set; }
        [JsonProperty(PropertyName = "push_message", NullValueHandling = NullValueHandling.Ignore)]
        public PushMessage PushMessage { get; set; }
        [JsonProperty(PropertyName = "push_channel", NullValueHandling = NullValueHandling.Ignore)]
        public PushChannel PushChannel { get; set; }
        [JsonProperty(PropertyName = "taskid", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }
        [JsonProperty(PropertyName = "is_async", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsync { get; set; }
        [JsonProperty(PropertyName = "msg_list", NullValueHandling = NullValueHandling.Ignore)]
        public CommonMessage[] MsgList { get; set; }

    }
}
