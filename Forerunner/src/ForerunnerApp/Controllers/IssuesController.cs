using ForerunnerInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ForerunnerApi.Controllers
{
    [Route("api/[controller]")]
    public class IssuesController : Controller
    {
        private static AppSettings _settings;
        IReader _reader;
        IWriter _writer;

        public IssuesController(IOptions<AppSettings> settings, IReader reader, IWriter writer)
        {
            _settings = settings.Value;
            _reader = reader;
            _writer = writer;
        }

        [HttpGet("{criteria}")]
        public string Get(object criteria)
        {
            return _reader.Get(criteria);
        }

        [HttpPost]
        public void Post([FromBody]object data)
        {
            data = new { fields = new { project = new { key = "TEST" }, summary = "hello there", description = "Creating of an issue using project keys and issue type names using the REST API", issueType = new { name = "Bug" } } };
            _writer.Post(data);
        }
    }
}
