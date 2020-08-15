using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class PushResultMessage : ResultMessage
    {
        public Dictionary<string, Dictionary<string, string>> Data { get; set; }
    }
}
