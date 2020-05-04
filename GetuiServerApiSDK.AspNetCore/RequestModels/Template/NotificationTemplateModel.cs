namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 点开通知打开应用模板
    /// </summary>
    public class NotificationTemplateModel : TemplateBase
    {
        public NotificationTemplateModel(bool isOffline = false)
        {
            Message = new Message {MsgType = "notification", IsOffline = isOffline};
        }

        public Notification Notification { get; set; }
    }
}
