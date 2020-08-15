using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class Setting
    {
        public long Ttl { get; set; } = 3600;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Strategy Strategy { get; set; }
        public int Speed { get; set; }
        [JsonProperty(PropertyName = "schedule_time")]
        public long ScheduleTime { get; set; }
    }
}
