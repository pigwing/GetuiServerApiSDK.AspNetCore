using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class MultiMedia
    {
        /// <summary>
        /// 多媒体资源地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 资源类型（1.图片，2.音频， 3.视频）
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 是否只在wifi环境下加载，如果设置成true,但未使用wifi时，会展示成普通通知
        /// </summary>
        [JsonProperty(PropertyName = "only_wifi")]
        public bool OnlyWifi { get; set; }
    }
}
