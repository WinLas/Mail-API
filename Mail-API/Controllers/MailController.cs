using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Mail_API.Filters;
using Mail_API.Models;
using Mail_API.Models.Db;
using Mail_API.Models.Dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
    [BasicAuth]
    [ApiController]
  //  [Produces("application/json")]
    public class MailController : ControllerBase
    {
        private readonly EmailService _service;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MailController(EmailService service, IHostingEnvironment environment)
    {
        _service = service;
        _hostingEnvironment = environment;
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
            var mailItem =  _service.GetById(id);
            if(mailItem == null)
            {
               return NotFound("The email with given id could not be found.");
            }
            return Ok(mailItem);
        }

        // POST: api/Mail
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]MailDto mail, IEnumerable<IFormFile> files)
       {
           if (!string.IsNullOrEmpty(mail.Sender) || mail.Receivers.Count > 0 || !string.IsNullOrEmpty(mail.Body))
           {
               foreach (var receiver in mail.Receivers)
               {
                   var dbMail = new Mail
                   {
                       Sender = mail.Sender,
                       Receiver = receiver,
                       Body = mail.Body,
                       CreatedTime = DateTime.Now,
                       Subject = mail.Subject,
                   };
                   if (mail.DontSend)
                   {
                       dbMail.DontSend = true;
                       dbMail.SentTime = DateTime.Now;
                   }
                   if (dbMail.IsValid())
                   {
                       dbMail.SetPixel(Request.Scheme + "://" + Request.Host + Request.PathBase);
                       await _service.AddMail(dbMail);
                       if (files != null)
                       {
                           foreach (var file in files)
                           {
                               var hash = Guid.NewGuid().ToString("N");
                               var filePath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "uploads"), hash);
                               using (var fileStream = new FileStream(filePath, FileMode.Create)) await file.CopyToAsync(fileStream);
                               var dbFile = new AttachmentFiles
                               {
                                   FilePath = filePath,
                                   Name = file.FileName
                               };
                               _service.SaveAttachment(dbFile);
                               var mailIdFileId = new MailIdFileId
                               {
                                   MailId = dbMail.Id,
                                   FileId = dbFile.Id
                               };
                               _service.SaveMailIdFileId(mailIdFileId);
                           }
                       }
                   }
               }
               return Ok(mail);
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
                return NotFound("The email with given external id could not be found.");
            }

            return Ok(dbMail);
        }
    }
}
