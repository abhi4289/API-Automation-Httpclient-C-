using NUnit.Framework;
using System.Net.Http;
using System.Text.Json;

namespace HttpClientDemo
{
    public class Tests
    {
        private HttpClient Client;
        private readonly string getUserPath = "api/users?page=2";

        [OneTimeSetUp]
        public void Setup()
        {
            HttpClient Client = new HttpClient
            {
                BaseAddress = new System.Uri("https://reqres.in")
            };
        }

        [Test]
        public void Test1()
        {
            HttpResponseMessage responseMessage = Client.GetAsync(getUserPath)
                .Result;
            responseMessage.EnsureSuccessStatusCode();
            GetUserResponse response = ReadAsAsync(responseMessage.Content);

            Assert.Multiple(() =>
            {
                Assert.That(response.data.Count, Is.GreaterThan(0));
                Assert.That(response.total, Is.EqualTo(2));
            });
        }

        public GetUserResponse ReadAsAsync(HttpContent content)
        {
            return JsonSerializer.Deserialize<GetUserResponse>(content.ReadAsStringAsync().Result);
        }
    }
}