using System;
using Newtonsoft.Json;

namespace GetuiServerApiSDK.AspNetCore.GetuiResult
{
    public class AuthTokenResult : ResultMessage
    {
        public TokenData Data { get; set; }
    }
    
}
