using System;
using System.Collections.Generic;
using System.Text;
using GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Android;
using GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Ios;

namespace GetuiServerApiSDK.AspNetCore.RequestModels
{
    public class PushChannel
    {
        public Android Android { get; set; }
        public Ios Ios { get; set; }
    }
}
