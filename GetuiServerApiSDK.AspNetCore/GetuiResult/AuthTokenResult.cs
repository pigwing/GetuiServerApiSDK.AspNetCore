using System;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class AuthTokenResult : ResultMessage
    {
        [JsonProperty(PropertyName = "auth_token")]
        public string AuthToken { get; set; }
        [JsonProperty(PropertyName = "expire_time")]
        public long ExpireTime { get; set; }

        public DateTime ExpireDateTime => new DateTime(Constants.UTC1970Tick + ExpireTime * 10000).AddMinutes(-5);//提前5分钟超时

        public override string ToString()
        {
            return
                $"authToken: {AuthToken} expireTime: {ExpireTime} expireDateTime: {ExpireDateTime.ToString("yyyy MM dd HH:mm:ss")} result: {Result} desc: {Desc}";
        }
    }
    
}
