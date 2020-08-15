using System;
using System.Collections.Generic;
using System.Text;

namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public static class Utc
    {
        public static long GetTimestamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - Constants.UTC1970Tick) / 10000;
        }

        public static string GetDuration(DateTime beginDateTime, DateTime endDateTime)
        {
            return string.Concat(
                (beginDateTime.ToUniversalTime().Ticks - Constants.UTC1970Tick) / 10000,
                "-",
                (endDateTime.ToUniversalTime().Ticks - Constants.UTC1970Tick) / 10000);
        }
    }
}
