using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

using Xunit;




namespace Integration.Testers
{
    public class VehicleFunctions
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public VehicleFunctions()
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
        public async Task getListOfCars()
        {
            var result = await this.client.GetAsync("/api/MyCarsApi/");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("11711", resultstring);
            Assert.Contains("LDP2264", resultstring);
        }

        [Fact]
        public async Task getCarById()
        {
            var result = await this.client.GetAsync("/api/MyCarsApi/3");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("11711", resultstring);
            Assert.DoesNotContain("LDP2264", resultstring);
        }
    }
}
