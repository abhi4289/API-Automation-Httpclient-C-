using HttpClientDemo.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientDemo
{
    public class LoginRequest: BaseRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
