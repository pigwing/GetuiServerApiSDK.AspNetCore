using System;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public abstract class ShowTimeBase
    {
        [JsonProperty(PropertyName = "duration_begin", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DurationBegin { get; set; }
        [JsonProperty(PropertyName = "duration_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DurationEnd { get; set; }
    }
}
