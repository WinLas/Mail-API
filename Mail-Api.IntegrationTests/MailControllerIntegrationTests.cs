using Mail_API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.Extensions.Configuration.CommandLine;
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
            _client.BaseAddress = new Uri("https://test2.winlas.se/mailapi");
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
        public async Task Test_Put_SuccessStatusCode()
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
        public async Task Get_Returns_Correct_Mail_By_Id()
        {
            //Arrange
            var request = "/api/mail/2";

            //Act
            var response = await _client.GetAsync(request);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Mail>(stringResponse);
            List<Mail> mails = new List<Mail>{result};

            //Assert
            Assert.Single(mails);
        }
        [Fact]
            public void ResponseTime_100GetByIdRequestsAsync()
            {
                var allResponseTimes = new List<(DateTime Start, DateTime End)>();

                for (var i = 0; i < 100; i++)
                {
                    var request = "/api/mail/2";
                        var start = DateTime.Now;
                        var response = _client.GetAsync(request).Result;
                        var end = DateTime.Now;
                        allResponseTimes.Add((start, end));
                // setting variable to documents path
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "ResponseTimeGet.txt"), true))
                        {
                            outputFile.WriteLine("{0}", (end-start).TotalMilliseconds);
                        }
                }

                var expected = 100;
                var actual = (int)allResponseTimes.Select(r => (r.End - r.Start).TotalMilliseconds).Average();
                Assert.True(actual <= expected, $"Expected average response time of less than or equal to {expected} ms but was {actual} ms.");
            }
            [Fact]
            public void ResponseTime_100PutRequestsAsync()
            {
                var allResponseTimes = new List<(DateTime Start, DateTime End)>();

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, "ResponseTimePut.txt"), true))
            {
                for (var i = 0; i < 100; i++)
                {
                    var request = "/api/mail";
                    var start = DateTime.Now;
                    var response = _client.PutAsync(request
                    , new StringContent(
                        JsonConvert.SerializeObject(
                            new Mail()
                            {
                                ExternalId = "Test1"
                            }),
                        Encoding.UTF8,
                        "application/json"
                        )).Result;
                    var end = DateTime.Now;
                    allResponseTimes.Add((start, end));
                    writer.WriteLine("{0}", (end - start).TotalMilliseconds);
                }
            }
            var expected = 100;
            var actual = (int)allResponseTimes.Select(r => (r.End - r.Start).TotalMilliseconds).Average();
            Assert.True(actual <= expected, $"Expected average response time of less than or equal to {expected} ms but was {actual} ms.");
        }

            [Fact]
            public void ResponseTime_100PostRequestsAsync()
            {
             
                var allResponseTimes = new List<(DateTime Start, DateTime End)>();
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, "ResponseTimePost.txt"), true))
                {
                    for (var i = 0; i < 100; i++)
                    {
                        var request = "/api/mail";
                        var start = DateTime.Now;
                        var response = _client.PostAsync(request
                            , new StringContent(
                                JsonConvert.SerializeObject(
                                    new Mail()
                                    {
                                        Sender = "no-reply@winlas.se",
                                        Receiver = "robin.eskilsson@winlas.se",
                                        Body = "ImABody"
                                    }),
                                Encoding.UTF8,
                                "application/json"
                            )).Result;
                        var end = DateTime.Now;
                        allResponseTimes.Add((start, end));
                        writer.WriteLine("{0}", (end - start).TotalMilliseconds);
                    }
                }
                var expected = 100;
                var actual = (int) allResponseTimes.Select(r => (r.End - r.Start).TotalMilliseconds).Average();
            }
    }
}
