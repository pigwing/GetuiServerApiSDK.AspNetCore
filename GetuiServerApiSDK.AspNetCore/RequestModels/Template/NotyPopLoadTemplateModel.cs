using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 点击通知弹窗下载模板
    /// </summary>
    public class NotyPopLoadTemplateModel : TemplateBase
    {
        public NotyPopLoadTemplateModel(bool isOffline = false)
        {
            Message = new Message {MsgType = "notypopload", IsOffline = isOffline};
        }
        [JsonProperty(PropertyName = "notypopload")]

        public NotyPopLoad NotyPopLoad { get; set; }
    }
}
