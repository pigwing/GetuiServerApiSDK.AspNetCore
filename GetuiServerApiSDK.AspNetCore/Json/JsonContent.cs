using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GetuiServerApiSDK.AspNetCore.Json
{
    public class JsonContent : StringContent
    {
        public JsonContent(object obj) : base(obj.ToJson(), Encoding.UTF8, "application/json")
        {
        }
    }
}
