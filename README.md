# GetuiServerApiSDK.AspNetCore

目前只实现了pubsh_single的模板单一推送.因为当前只用到了他.

### 使用方式
`
GetuiConfiguration getuiConfiguration = new GetuiConfiguration()
{
    AppId = "",
    AppKey = "",
    MasterSecret = ""
};
services.AddSingleton(getuiConfiguration);


services.AddServiceApi();

PushTemplateMessageService pushTemplateMessageService = services.GetRequiredService<PushTemplateMessageService>();
PushResultMessage pushResultMessage;
pushResultMessage = await PushNotificationTemplateToSingle(pushTemplateMessageService);
pushResultMessage = await PushLinkTemplateToSingle(pushTemplateMessageService);
pushResultMessage = await PushNotyPopLoadTemplateToSingle(pushTemplateMessageService);
pushResultMessage = await PushNotyPopLoadTemplateToSingle(pushTemplateMessageService);
pushResultMessage = await PushTransmissionTemplateToSingle(pushTemplateMessageService);`
