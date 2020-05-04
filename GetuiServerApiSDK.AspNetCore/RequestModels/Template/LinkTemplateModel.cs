namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 点开通知打开网页模板
    /// </summary>
    public class LinkTemplateModel : TemplateBase
    {
        public LinkTemplateModel(bool isOffline = false)
        {
            Message = new Message { MsgType = "link", IsOffline = false};
        }
        public Link Link { get; set; }
    }
}
