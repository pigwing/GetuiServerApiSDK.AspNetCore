using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class NotyPopLoad : ShowTimeBase
    {
        public Style Style { get; set; }

        /// <summary>
        /// 通知栏图标
        /// </summary>
        [JsonProperty(PropertyName = "notyicon")]
        public string NotyIcon { get; set; }
        /// <summary>
        /// 通知标题
        /// </summary>
        [JsonProperty(PropertyName = "notytitle")]
        public string NotyTitle { get; set; }
        /// <summary>
        /// 通知内容
        /// </summary>
        [JsonProperty(PropertyName = "notycontent")]
        public string NotyContent { get; set; }
        /// <summary>
        /// 弹出框标题
        /// </summary>
        [JsonProperty(PropertyName = "poptitle")]
        public string PopTitle { get; set; }
        /// <summary>
        /// 弹出框内容
        /// </summary>
        [JsonProperty(PropertyName = "popcontent")]
        public string PopContent { get; set; }
        /// <summary>
        /// 弹出框图标
        /// </summary>
        [JsonProperty(PropertyName = "popimage")]
        public string PopImage { get; set; }
        /// <summary>
        /// 弹出框左边按钮名称
        /// </summary>
        [JsonProperty(PropertyName = "popbutton1")]
        public string PopLeftButton { get; set; }
        /// <summary>
        /// 弹出框右边按钮名称
        /// </summary>
        [JsonProperty(PropertyName = "popbutton2")]
        public string PopRightButton { get; set; }
        /// <summary>
        /// 现在图标
        /// </summary>
        [JsonProperty(PropertyName = "loadicon", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadIcon { get; set; }
        /// <summary>
        /// 下载标题
        /// </summary>
        [JsonProperty(PropertyName = "loadtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadTitle { get; set; }
        /// <summary>
        /// 下载文件地址
        /// </summary>
        [JsonProperty(PropertyName = "loadurl")]
        public string LoadUrl { get; set; }
        /// <summary>
        /// 是否自动安装，默认值false
        /// </summary>
        [JsonProperty(PropertyName = "is_autoinstall")]
        public bool IsAutoInstall { get; set; }
        /// <summary>
        /// 安装完成后是否自动启动应用程序，默认值false
        /// </summary>
        [JsonProperty(PropertyName = "is_actived")]
        public bool IsActived { get; set; }

    }
}
