using System;
using System.Threading.Tasks;
using Mail_API.Filters;
using Mail_API.Models;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
  //  [BasicAuth]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly EmailService _service;

        public MailController(EmailService service)
    {
        _service = service;
    }
        // GET: api/Mail
        [HttpGet]
        public async Task<IActionResult> Get()
      {
          var mails = _service.GetAllMails();
          return Ok(mails);
      }

        // GET: api/Mail/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var mailItem = _service.GetById(id);
            if(mailItem == null)
            {
               return NotFound("The email with given id could not be found.");
            }
            return Ok(mailItem);
        }

        // POST: api/Mail
        [HttpPost]
        public async Task<IActionResult> Post(Mail mail)
       {
           if (mail.IsValid())
           {
               mail.SetPixel(Request.Scheme + "://" + Request.Host + Request.PathBase +
                             Url.Action("getPixel", "Track"));
               await _service.AddMail(mail);
               return Ok(mail.Id);
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
