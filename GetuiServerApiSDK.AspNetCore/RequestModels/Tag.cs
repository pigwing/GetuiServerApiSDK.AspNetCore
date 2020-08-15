using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class Tag
    {
        public string Key { get; set; }
        public string[] Values { get; set; }
        [JsonProperty(PropertyName = "opt_type")]
        public string OptType { get; set; }
    }
}
