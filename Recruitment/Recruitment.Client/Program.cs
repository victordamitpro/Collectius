using CommandQuery.Client;
using Newtonsoft.Json;
using Recruitment.Contracts.Commands;
using System;
using System.Threading.Tasks;


namespace Recruitment.Client
{
    public class Program
    {
        private const string url = "https://localhost:5003/api/command/calculatehashcommand";
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, press [Enter] to proceed...");
            Console.ReadLine();

            var commandClient = new CommandClient(url);
            var result = await commandClient.PostAsync(new CalculateHashCommand { Login = "Admin", PassWord= "abcde12345-" });
            Console.WriteLine(JsonConvert.SerializeObject(result));
            Console.WriteLine("Press [Enter] to exit");
            Console.ReadLine();
        }
    }
}
