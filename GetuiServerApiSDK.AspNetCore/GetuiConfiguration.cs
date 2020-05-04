namespace GetuiServerApiSDK.AspNetCore
{
    public class GetuiConfiguration
    {
        public string AppId { get; set; }
        public string AppKey { get; set; }
        public string MasterSecret { get; set; }
        public string ApiVersion { get; set; } = "v1";
    }
}
