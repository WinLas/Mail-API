using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace Mail_API.Models
{
    public class APIService
    {
        public APIService()
        {

        }

        public bool VerifyKey(string apiKey)
        {
            var client = new RestClient("https://localhost");
            RestRequest request = new RestRequest("/wloffice/api/key", Method.POST);
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
