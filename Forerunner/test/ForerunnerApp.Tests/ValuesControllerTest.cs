using ForerunnerApp.Controllers;
using Xunit;

namespace ForerunnerApp.Tests
{
    public class ValuesControllerTest
    {
        private readonly ValuesController _controller;

        public ValuesControllerTest()
        {
            _controller = new ValuesController();
        }

        [Fact]
        public void Get_ShouldReturnSomething()
        {
            var result = _controller.Get();
            Assert.NotEmpty(result);
        }
    }
}
