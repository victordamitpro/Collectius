using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Recruitment.API;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Recuitment.Tests
{
    public class Tests
    {
        HttpClient Client;

        [SetUp]
        public void Setup()
        {
            var factory = new WebApplicationFactory<Startup>();
            Client = factory.CreateClient();
        }

        [Test]
        public async Task Should_Success()
        {
            var content = new StringContent("{ \"Login\": \"Admin\", \"PassWord\": \"123456\"}", Encoding.UTF8, "application/json");
            var result = await Client.PostAsync("/api/command/calculatehashcommand", content);

            result.EnsureSuccessStatusCode();
            (await result.Content.ReadAsStringAsync()).Should().NotBeEmpty();
        }
    }
}