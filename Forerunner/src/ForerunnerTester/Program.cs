using System;
using System.Net.Http;
using System.Threading;

namespace ForerunnerTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.Sleep(3 * 1000);
            CallForerunnerGet();
            Console.ReadLine();
        }

        static async void CallForerunnerGet()
        {
            var httpClient = new HttpClient();
            var call = await httpClient.GetAsync("http://localhost:57859/api/issues/criteria");
            var httpResponse = await call.Content.ReadAsStringAsync();

            Console.WriteLine(httpResponse);
        }
    }
}
