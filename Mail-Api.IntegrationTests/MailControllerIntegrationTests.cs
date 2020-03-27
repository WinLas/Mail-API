using Mail_API;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mail_API.Models.Db;
using Newtonsoft.Json;
using Xunit;

namespace Mail_Api.IntegrationTests
{
    // IClassFixture indicates tests in this class rely on TestingWebbAppFactory to run
   public class MailControllerIntegrationTests : IClassFixture<TestingWebAppFactory<Startup>>
    {
        private readonly HttpClient _client;
        // Create instance of httpclient. 
        public MailControllerIntegrationTests(TestingWebAppFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Test_Get()
        {
            // Arrange
            var request = "/api/Mail";

            //Act
            var response = await _client.GetAsync(request);
            var value = await response.Content.ReadAsStringAsync();

            //Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Test_Post()
        {
            //Arrange
            var request = "/api/Mail";
           
            //Act
            var response = await _client.PostAsync(request
                , new StringContent(
                    JsonConvert.SerializeObject(new Mail()
                        {
                            Sender = "Hejzz@hejzz.se",
                            Receiver = "Hejzzz@hejzzz.se",
                            Body = "Body"
                        }),
                    Encoding.UTF8,
                        "application/json"));

            response.EnsureSuccessStatusCode();

            response.StatusCode.Equals(HttpStatusCode.OK);
        }
    }
}
