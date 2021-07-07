using HttpClientDemo.Requests;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace HttpClientDemo
{
    public class BaseClient
    {
        protected HttpClient Client;
        
        public BaseClient()
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri("<App URL>")
            };
        }

        public T GetRequest<T>(string url)
        {
            HttpResponseMessage responseMessage1 = Client.GetAsync(url)
                .Result;
            responseMessage1.EnsureSuccessStatusCode();
            return Deserialize<T>(responseMessage1.Content);
        }

        public T PostRequest<T>(string url,BaseRequest request)
        {
            string json = Serialize(request);
            HttpResponseMessage responseMessage = Client.PostAsync(url, new StringContent(json, System.Text.Encoding.UTF8, "application/json")).Result;
            responseMessage.EnsureSuccessStatusCode();

            return Deserialize<T>(responseMessage.Content);

        }

        public T Deserialize<T>(HttpContent content)
        {
            return JsonSerializer.Deserialize<T>(content.ReadAsStringAsync().Result);
        }

        public string Serialize<T>(T request)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(request,request.GetType(), options);
        }
    }
}
