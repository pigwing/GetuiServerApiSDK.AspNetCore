namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public abstract class ServiceBase
    {
        private readonly GetuiConfiguration _getuiConfiguration;

        protected ServiceBase(GetuiConfiguration getuiConfiguration)
        {
            _getuiConfiguration = getuiConfiguration;
        }

        public string GetTokenKey()
        {
            string tokenKey = string.Concat(_getuiConfiguration.AppId, ".", _getuiConfiguration.AppKey, ".",
                _getuiConfiguration.MasterSecret);
            return tokenKey;
        }
    }
}
