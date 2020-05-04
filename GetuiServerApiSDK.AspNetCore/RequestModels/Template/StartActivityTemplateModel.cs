using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 点开通知打开应用内特定页面模板
    /// </summary>
    public class StartActivityTemplateModel : TemplateBase
    {
        public StartActivityTemplateModel(bool isOffline = false) : this(isOffline, null, null)
        {

        }
        public StartActivityTemplateModel(bool isOffline, long? offlineExpireTime, int? pushNetWorkType)
        {
            Message = new Message
            {
                MsgType = "startactivity", IsOffline = isOffline, OfflineExpireTime = offlineExpireTime,
                PushNetWorkType = pushNetWorkType
            };
        }
        public StartActivityStyle Style { get; set; }
        [JsonProperty(PropertyName = "startactivity")]
        public StartActivity StartActivity { get; set; }
    }
}
