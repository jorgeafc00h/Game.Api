using ApiClient;
using System;
using System.Threading.Tasks;

namespace ConsoleHubClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Task.Run(GameService.Run).Wait();
		}
    }
}
