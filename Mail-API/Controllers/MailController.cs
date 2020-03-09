using System;
using System.Threading.Tasks;
using Mail_API.Filters;
using Mail_API.Models;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
    [BasicAuth]
    [ApiController]
    public class MailController : ControllerBase
    {

        private readonly MailDbContext _context;
        private readonly EmailService _service;

        public MailController(MailDbContext context, EmailService service)
    {
        _context = context;
        _service = service;
    }
        // GET: api/Mail
        [HttpGet]
        public async Task<IActionResult> Get()
      {
          var mails = _service.GetAllMails();
          return Ok(mails);
      }

        // GET: api/Mail/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Mail mail)
        {
            var dbMail = _service.GetById(mail);
            if(dbMail == null)
            {
               return NotFound("The email with given id could not be found.");
            }
            return Ok(dbMail);
        }

        // POST: api/Mail
        [HttpPost]
        public async Task<IActionResult> Post(Mail value)
       {
           if (value.IsValid())
           {
                string trackingId = Guid.NewGuid().ToString();
                value.TrackerId = trackingId; 
                string imageHtml = "<img src='" + Request.Scheme + "://" + Request.Host + Request.PathBase + Url.Action("getPixel", "Track", new { trackingId = trackingId }) + "'>";
                value.Body = value.Body + imageHtml;
                _context.Mails.Add(value);
                _context.SaveChanges();
               return Ok(value.Id);
           }
           return NotFound("The email must have a receiver, sender and a body.");
       }

        // PUT: api/Mail/5
        [HttpPut]
        public async Task<IActionResult> Put(Mail mail)
        {
            var dbMail = _service.UpdateMail(mail);
            if (dbMail == null)
            {
                return NotFound("The email with given id could not be found.");
            }

            return Ok(dbMail);
        }

        // DELETE: api/ApiWithActions/5
    /*    [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
