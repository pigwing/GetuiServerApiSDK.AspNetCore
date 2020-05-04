using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.RequestModels.Template
{
    public class StartActivity : ShowTimeBase
    {
        /// <summary>
        /// 收到消息是否立即启动应用，true为立即启动，false则广播等待启动，默认是否
        /// </summary>
        [JsonProperty(PropertyName = "transmission_type")]
        public bool TransmissionType { get; set; }
        /// <summary>
        /// 透传内容
        /// </summary>
        [JsonProperty(PropertyName = "transmission_content")]
        public string TransmissionContent { get; set; }
        /// <summary>
        /// 应用内页面intent
        ///【Android】长度小于1000字节，intent参数（以intent:开头;end结尾）
        /// 示例：intent:#Intent;component=你的包名/你要打开的 activity 全路径;S.parm1=value1;S.parm2=value2;end
        /// </summary>
        public string Intent { get; set; }
        public Style Style { get; set; }
    }
}
