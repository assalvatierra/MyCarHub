using System;
using Xunit;

using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MyCarCare.Tests.Integration
{
    public class HomeTester
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public HomeTester()
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
        public async Task OnGet_unauthenticated_shouldloadpage()
        {
            var result = await this.client.GetAsync("/");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("Welcome to MyCarCare", resultstring);
            Assert.Contains("managing your fleet", resultstring);
            Assert.DoesNotContain("Admin user", resultstring);
            Assert.DoesNotContain("for garage user", resultstring);
            Assert.DoesNotContain("for driver", resultstring);
            Assert.DoesNotContain("for fleet manager", resultstring);
        }

        //public async Task OnGet_authenticated_shouldloadpage()
        //{
        //}
        [Theory]
        [InlineData("/")]
        [InlineData("/Index")]
        [InlineData("/About")]
        [InlineData("/Privacy")]
        [InlineData("/Contact")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = this.server.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

    }



    public class TransactionTester
    {
        private readonly TestServer server;
        private readonly HttpClient client;
        public TransactionTester()
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
        public async Task Onget_CreateFuelTrx_MustLoadPage()
        {
            var result = await this.client.GetAsync("/Transactions/Fuel/Create");
            var resultstring = await result.Content.ReadAsStringAsync();
            Assert.Contains("MyCarFuel", resultstring);

        }
    }
}
