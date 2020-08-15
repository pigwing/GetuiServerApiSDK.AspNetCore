using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Channel.Ios
{
    public class Alert
    {
        /// <summary>
        /// 通知标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 通知文本消息
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// （用于多语言支持）指定执行按钮所使用的Localizable.strings
        /// </summary>
        [JsonProperty(PropertyName = "action-loc-key", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionLocKey { get; set; }
        /// <summary>
        /// （用于多语言支持）指定Localizable.strings文件中相应的key
        /// </summary>
        [JsonProperty(PropertyName = "loc-key", NullValueHandling = NullValueHandling.Ignore)]
        public string LocKey { get; set; }
        [JsonProperty(PropertyName = "loc-args", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LocArgs { get; set; }
        /// <summary>
        /// 指定启动界面图片名
        /// </summary>
        [JsonProperty(PropertyName = "launch-image", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchImage { get; set; }
        /// <summary>
        /// (用于多语言支持）对于标题指定执行按钮所使用的Localizable.strings,仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty(PropertyName = "title-loc-key", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleLocKey { get; set; }
        /// <summary>
        /// 对于标题,如果loc-key中使用的占位符，则在loc-args中指定各参数,仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty(PropertyName = "title-loc-args", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleLocArgs { get; set; }
        /// <summary>
        /// 通知子标题,仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty(PropertyName = "subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTitle { get; set; }
        /// <summary>
        /// 当前本地化文件中的子标题字符串的关键字,仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty(PropertyName = "subtitle-loc-key", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleLocKey { get; set; }
        /// <summary>
        /// 当前本地化子标题内容中需要置换的变量参数 ,仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty(PropertyName = "subtitle-loc-args", NullValueHandling = NullValueHandling.Ignore)]
        public string[] SubtitleLocArgs { get; set; }
    }
}
