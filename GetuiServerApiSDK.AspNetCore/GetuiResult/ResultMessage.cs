using System.Net;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class ResultMessage
    {
        public string Result { get; set; }
        public string Desc { get; set; }
        public HttpStatusCode ClientHttpStatusCode { get; set; }

        protected virtual string GetMessage(string str)
        {
            switch (str)
            {
                case "ok":
                    return "成功";
                case "no_msg":
                    return "没有消息体";
                case "alias_error":
                    return "找不到别名";
                case "black_ip":
                    return "黑名单ip";
                case "sign_error":
                    return "鉴权失败";
                case "pushnum_overlimit":
                    return "推送次数超限";
                case "no_appid":
                    return "找不到appid";
                case "no_user":
                    return "找不到对应用户";
                case "too_frequent":
                    return "推送过于频繁";
                case "sensitive_word":
                    return "有敏感词出现";
                case "appid_notmatch":
                    return "appid与cid或者appkey不匹配";
                case "not_auth":
                    return "用户没有鉴权";
                case "black_appid":
                    return "黑名单app";
                case "invalid_param":
                    return "参数检验不通过";
                case "alias_notbind":
                    return "别名没有绑定cid";
                case "tag_over_limit":
                    return "tag个数超限";
                case "successed_online":
                    return "在线下发";
                case "successed_offline":
                    return "离线下发";
                case "taginvalid_or_noauth":
                    return "tag无效或者没有使用权限";
                case "no_valid_push":
                    return "没有有效下发";
                case "successed_ignore":
                    return "忽略非活跃用户";
                case "no_taskid":
                    return "找不到taskid";
                case "other_error":
                    return "其他错误";
                default:
                    return "";
            }
        }

        public string ResultDescription => GetMessage(Result);

        public override string ToString()
        {
            return $"result: {Result} desc: {Desc}";
        }
    }
}
