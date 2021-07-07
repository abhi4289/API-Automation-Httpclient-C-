using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientDemo
{
    public class LoginResponse: BaseResponse
    {
        public string UserId { get; set; }
        public string ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsMFARequired { get; set; }
        public bool IsSAMLEnabled { get; set; }
        public bool IsLoggedInUserSystemAdmin { get; set; }
        public string RedirectUrl { get; set; }
        public int SessionTimeoutInMinutes { get; set; }
        public string DateFormat { get; set; }
        public bool IsPasswordChangeRequired { get; set; }
        public string Language { get; set; }
        public string UserLocale { get; set; }
        public string DecimalSeparator { get; set; }
        public bool IsPasswordExpired { get; set; }
        public string Theme { get; set; }
        public string HeaderColor { get; set; }
        public string LinkColor { get; set; }
        public string ClientName { get; set; }
        public bool HasAdminBasicRole { get; set; }
        public bool HasUserManagementRole { get; set; }
        public string SessionId { get; set; }
        public string ProgramId { get; set; }
        public string AccessToken { get; set; }
        public string LoginName { get; set; }
        public bool HasOnlyAPIAccess { get; set; }
        public object MFAAuthToken { get; set; }
    }
}
