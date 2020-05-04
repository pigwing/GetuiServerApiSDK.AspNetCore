using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class PushResultMessage : ResultMessage
    {
        public string Status { get; set; }
        [JsonProperty(PropertyName = "taskid")]
        public string TaskId { get; set; }

        public string StatusMessage => GetMessage(Status);

        public override string ToString()
        {
            return $"result: {Result} taskId: {TaskId} stauts: {Status}";
        }
    }
}
