using ForerunnerInterfaces;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;
using Microsoft.Extensions.Options;

namespace ForerunnerWriter
{
    public class Writer : IWriter
    {
        private readonly string _uri = "";
        private HttpClient _client;

        public Writer(IOptions<AppSettings> settings)
        {
            _uri = settings.Value.Writer.Uri;
            _client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes(settings.Value.Writer.Credentials);
            var header = new AuthenticationHeaderValue(
               "Basic", Convert.ToBase64String(byteArray));
            _client.DefaultRequestHeaders.Authorization = header;
        }

        public void Post(object data)
        {
            if (!Exists(data))
            {
                _client.PostAsync(_uri, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            }
        }
        
        //check by TraceId
        protected bool Exists(object data)
        {
            return false;
        }
    }
}
