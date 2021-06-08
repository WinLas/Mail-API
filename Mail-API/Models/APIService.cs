using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace Mail_API.Models
{
    public class APIService
    {
        private IConfiguration _configuration;
        private readonly string _wloUrl;
        public APIService(IConfiguration configuration)
        {
            _configuration = configuration;
            _wloUrl = _configuration.GetSection("Parameters").GetSection("WLO-URL").Value;
        }

        public bool VerifyKey(string apiKey)
        {
            var client = new RestClient(_wloUrl);
            RestRequest request = new RestRequest("/api/key", Method.POST);
            client.Authenticator = new HttpBasicAuthenticator(apiKey,"");
            var response = client.Execute(request);
            var content = response.Content;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;

        }
    }
}
