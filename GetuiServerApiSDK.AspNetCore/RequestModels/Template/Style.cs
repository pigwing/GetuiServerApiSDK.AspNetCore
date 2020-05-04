using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    /// <summary>
    /// 通知栏消息布局样式
    /// </summary>
    public class Style
    {
        /// <summary>
        /// 固定为0
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 通知内容
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 通知标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 通知展示样式,枚举值包括 1,2(style=0时，big_style只能为1或者2)
        /// 1	big_image_url	通知展示大图样式，参数是大图的URL地址
        /// 2	big_text 通知展示文本+长文本样式，参数是长文本
        /// 3	big_image_url,banner_url 通知展示大图+小图样式，参数是大图URL和小图URL
        /// </summary>
        [JsonProperty(PropertyName = "big_style")]
        public int BigStyle { get; set; } = 1;
        /// <summary>
        /// 知展示文本+大图样式，参数 大图URL地址
        /// </summary>
        [JsonProperty(PropertyName = "big_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BigImageUrl { get; set; }

        public string Logo { get; set; } = "";
        /// <summary>
        /// 通知图标URL地址
        /// </summary>
        [JsonProperty(PropertyName = "logourl", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoUrl { get; set; }
        /// <summary>
        /// 是否响铃
        /// </summary>
        [JsonProperty(PropertyName = "is_ring")]
        public bool IsRing { get; set; }
        /// <summary>
        /// 是否震动
        /// </summary>
        [JsonProperty(PropertyName = "is_vibrate")]
        public bool IsVibrate { get; set; }
        /// <summary>
        /// 是否可以清除
        /// </summary>
        [JsonProperty(PropertyName = "is_clearable")]
        public bool IsClearable { get; set; }
        /// <summary>
        /// 需要被覆盖的消息已经增加了notifyId字段，用于实现下发消息的覆盖。新的消息使用相同的notifyId下发。
        /// </summary>
        [JsonProperty(PropertyName = "notify_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotifyId { get; set; }

    }
}
