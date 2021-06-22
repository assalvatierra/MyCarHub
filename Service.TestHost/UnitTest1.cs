using System;
using Xunit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace Integration.TestHost
{
    public class UnitTest1
    {
        private readonly TestServer server;
        private readonly HttpClient client;
        public UnitTest1()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            this.server = new TestServer(new WebHostBuilder()
                .UseConfiguration(configuration)
                .UseStartup<Startup>()
                );

            this.client = this.server.CreateClient();
        }


        [Fact]
        public async Task Test1()
        {

            var result = await this.client.GetAsync("/api/MyCarsApi/");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("11711", resultstring );

        }
    }
}
