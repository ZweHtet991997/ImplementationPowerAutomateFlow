namespace Home_Loan_Landing_Support
{
    public class ApiURLRouter
    {
        private IConfiguration _configuration;

        public ApiURLRouter(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string GetListApiUrl()
        {
            return _configuration.GetValue<string>("GetListApiUrl");
        }

        public string CreateApiUrl()
        {
            return _configuration.GetValue<string>("CreateApirUrl");
        }

        public string UpdateApiUrl()
        {
            return _configuration.GetValue<string>("UpdateApiUrl");
        }

        public string GetLSByCaseIDApiUrl()
        {
            return _configuration.GetValue<string>("GetLSByCaseIDApiUrl");
        }
    }
}
