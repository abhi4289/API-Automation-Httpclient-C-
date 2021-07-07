using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace HttpClientDemo
{
    public class Tests
    {
        [TestCase("data2@api.com")]
        public void Login(string email)
        {
            UserClient client = new UserClient();
            client.GetApplicationSettings() ;

            LoginRequest loginRequest = new LoginRequest
            {
                Email = "data2@api.com",
                Password = "Welcome@12345"
            };
            LoginResponse loginResponse = client.Login(loginRequest);

            Assert.That(loginResponse.AccessToken, Is.Not.Null);
            Assert.That(loginResponse.Email, Is.EqualTo(email));

        }
    }
}