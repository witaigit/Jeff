using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Jeff
{
    class Program
    {
        private const string Token = "TP3U4KWLFURRNHYXVNAFMRCPM2B4VY2J";

        private static HttpClient _client;

        private static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient()
                    {
                        BaseAddress = new Uri("https://api.wit.ai/")
                    };
                    _client.DefaultRequestHeaders.Accept.Clear();
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.wit.20141022+json"));
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.Token);
                }
                return _client;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}