using Mail_API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public async Task Test_Get_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/Mail";

            //Act
            var response = await _client.GetAsync(request);
            var value = await response.Content.ReadAsStringAsync();

            //Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Equals(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Test_Post_SuccessStatusCode()
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
            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Equals(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Test_PutSuccessStatusCode()
        {
            //Arrange 
            var request = "/api/Mail";

            //Act
            var response = await _client.PutAsync(request
                , new StringContent(
                    JsonConvert.SerializeObject(
                        new Mail()
                        {
                            ExternalId = "Test1"
                        }),
                    Encoding.UTF8,
                    "application/json"));

            //Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Equals(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Get_Returns_Correct_Mail()
        {
            //Arrange
            var request = "/api/Mail/1";

            //Act
            var response = await _client.GetAsync(request);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Mail>(stringResponse);
            List<Mail> mails = new List<Mail>{result};

            //Assert
            Assert.Single(mails);
        }
    }
}
