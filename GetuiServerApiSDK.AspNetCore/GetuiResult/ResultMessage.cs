using System.Net;
using System.Net.Http.Headers;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class ResultMessage
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public HttpStatusCode ClientHttpStatusCode { get; set; }

        protected virtual string GetMessage(int str)
        {
            switch (str)
            {
                case 200:
                    return "成功";
                case 301:
                    return "域名错误";
                case 400:
                    return "参数错误";
                case 401:
                    return "权限相关";
                case 403:
                    return "套餐相关";
                case 404:
                    return "url错误";
                case 405:
                    return "方法不支持";
                case 0:
                    return "成功";
                case 1:
                    return "失败";
                case 2:
                    return "服务正在启动";
                case 10001:
                    return "token错误/失效";
                case 10002:
                    return "appId或ip在黑名单中";
                case 10003:
                    return "每分钟鉴权频率超限";
                case 20001:
                    return "参数不合法";
                case 21001:
                    return "推送失败，用户无效/策略参数错误导致推送失败";
                case 22001:
                    return "定时任务已经执行，无法删除";
                case 22002:
                    return "任务无效或定时任务时间不合法";
                case 23001:
                    return "操作tag失败";
                case 30000:
                    return "没有推送fast_custom_tag的权限";
                case 30001:
                    return "没有修改和删除custom_tag的权限";
                case 30002:
                    return "没有推送定时任务的权限";
                case 30003:
                    return "app/tag 接口无权限，或tag无效";
                case 30004:
                    return "tag每日推送总数超限(VIP用户可根据应用特殊配置)";
                case 30005:
                    return "tag长度超限(tag长度<32)";
                case 30006:
                    return "fast_custom_tag次数超过每日推送总数限制(VIP用户可根据应用特殊配置)";
                case 30007:
                    return "app/all推送，推送次数超过每日推送总数限制，每日最多推送100次";
                case 30008:
                    return "list推送次数超过每日推送总数限制，每日最多推送2000000次";
                case 30009:
                    return "推送次数超过每日推送总数限制";
                case 30010:
                    return "app/tag 推送次数超过每日推送总数限制，每日最多推送100次，和接口app/all共享限制";
                case 30011:
                    return "设置tag次数超过每日次数限制";
                case 30012:
                    return "修改和删除tag 超过每分钟频率限制，每分钟最多操作5次";
                case 30013:
                    return "推送fast_custom_tag频率超过每分钟频率限制(VIP用户可根据应用特殊配置)";
                case 30014:
                    return "app 推送 频率超过每分钟频率限制，每分钟最多操作5次";
                case 30015:
                    return "list推送 频率超过每分钟频率限制";
                case 30016:
                    return "push/tag tag个数超过限制";
                default:
                    return "未知异常";
            }
        }

        public string ResultDescription => GetMessage(Code);

        public override string ToString()
        {
            return $"result: {Code} desc: {Msg}";
        }
    }
}
