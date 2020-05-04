using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class StartActivityStyle : Style
    {
        /// <summary>
        /// 通知渠道名称，默认Default
        /// </summary>
        [JsonProperty(PropertyName = "channel_name")]
        public string ChannelName { get; set; } = "Default";
        [JsonProperty(PropertyName = "channel_name")]
        public string ChannelId { get; set; } = "Default";
        /// <summary>
        /// 该字段代表通知渠道重要性，具体值有0、1、2、3、4；
        /// 设置之后不能修改；具体展示形式如下：
        /// 0：无声音，无震动，不显示。(不推荐)
        /// 1：无声音，无震动，锁屏不显示，通知栏中被折叠显示，导航栏无logo。
        /// 2：无声音，无震动，锁屏和通知栏中都显示，通知不唤醒屏幕。
        /// 3：有声音，有震动，锁屏和通知栏中都显示，通知唤醒屏幕。（推荐）
        /// 4：有声音，有震动，亮屏下通知悬浮展示，锁屏通知以默认形式展示且唤醒屏幕。（推荐）
        /// </summary>
        [JsonProperty(PropertyName = "channel_level")]
        public int ChannelLevel { get; set; }
    }
}
