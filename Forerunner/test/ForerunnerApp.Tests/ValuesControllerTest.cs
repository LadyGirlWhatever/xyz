using System;
using ForerunnerApi.Controllers;
using Microsoft.Extensions.Options;
using Xunit;

namespace ForerunnerApi.Tests
{
    public class ValuesControllerTest
    {
        private readonly IssuesController _controller;

        public ValuesControllerTest()
        {
           // _controller = new IssuesController(new OptionsMock());
        }

        [Fact]
        public void Get_ShouldCallIReader()
        {
            var result = _controller.Get(new object());
            Assert.NotEmpty(result);
        }
    }

    //public class OptionsMock : IOptions<AppSettings>
    //{
    //    public AppSettings Value => new AppSettings { Reader = new ServerSettings { Uri = "" }, Writer = new ServerSettings { Uri = "", Credentials = "" } };
    //}
}
