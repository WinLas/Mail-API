using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    public class LoginController : Controller
    {
    
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login()
        {
    
            var url = "https://konto.winlas.se/api/auth";
            var username = HttpContext.Request.Form["username"].FirstOrDefault();
            var password = Request.Form["password"].FirstOrDefault();

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            });


            var byteArray = Encoding.ASCII.GetBytes("8TIREklkC63JunyRYSSi2zDsiz5R1InA:");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            // The Uri the request is sent to and the request content.
            HttpResponseMessage response = await client.PostAsync(url, formContent);

            // HTTP request content sent to the server.
            HttpContent content = response.Content;

            string result = await content.ReadAsStringAsync();

            return Ok(result);
        }
    }
}