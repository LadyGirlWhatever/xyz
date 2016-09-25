using ForerunnerInterfaces;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace ForerunnerReader
{
    public class Reader : IReader
    {
        private readonly string _uri;
        private HttpClient _client;

        public Reader(IOptions<AppSettings> settings)
        {
            _uri = settings.Value.Reader.Uri;
            _client = new HttpClient();
        }

        public string Get(object criteria)
        {
            return _client.GetAsync($"{_uri}/{JsonConvert.SerializeObject(criteria)}").Result.Content.ReadAsStringAsync().Result;
        }
    }
}
