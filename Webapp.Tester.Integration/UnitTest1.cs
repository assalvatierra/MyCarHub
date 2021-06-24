using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;


using Xunit;

namespace Webapp.Tester.Integration
{
    public class VehicleRazorPages
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public VehicleRazorPages()
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
        public async Task List()
        {
            var result = await this.client.GetAsync("/vehicles");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("11711", resultstring);
            Assert.Contains("LDP2264", resultstring);
        }

        [Fact]
        public async Task GetMyCarById()
        {
            var result = await this.client.GetAsync("/Vehicles/Edit?id=3");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("11711", resultstring);
            Assert.Contains("4x4", resultstring);
            Assert.DoesNotContain("LDP2264", resultstring);
        }
    }
}
