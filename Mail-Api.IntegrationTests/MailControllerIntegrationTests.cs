using Mail_API;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
        public async Task Index_WhenCalled_ReturnsApplicationForm()
        {
            var response = await _client.GetAsync("api/Mail");

            response.EnsureSuccessStatusCode();


            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Contains("Test1", responseString);
            Assert.Contains("Test2", responseString);
        }
    }
}
