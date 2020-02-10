using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mail_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        // GET: api/Mail
        [HttpGet]
        public IEnumerable<Mail> Get()
        {
            return new Mail[] { new Mail() };
        }

        // GET: api/Mail/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mail
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Mail/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
