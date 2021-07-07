using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientDemo
{
    public class UserClient : BaseClient
    {
        public AppSettingResponse GetApplicationSettings()
        {
            AppSettingResponse response = GetRequest<AppSettingResponse>("/api/account/login");
            Client.DefaultRequestHeaders.Add("sessionid", response.SessionId);
            return response;
        }
        public LoginResponse Login(LoginRequest request)
        {
            return PostRequest<LoginResponse>("api/Application/GetApplicationSettings", request);
        }
    }
}
