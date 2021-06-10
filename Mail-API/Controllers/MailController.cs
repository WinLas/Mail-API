using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Mail_API.Filters;
using Mail_API.Models;
using Mail_API.Models.Db;
using Mail_API.Models.Dto;
using Mail_API.Models.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Controllers
{
    [Route("/")]
    [BasicAuth]
    [ApiController]
  //  [Produces("application/json")]
    public class MailController : ControllerBase
    {
        private readonly EmailService _service;
        private readonly IHostingEnvironment _hostingEnvironment;
        private ILog _logger;

        public MailController(EmailService service, IHostingEnvironment environment, ILog logger)
        {
            _service = service;
            _hostingEnvironment = environment;
            _logger = logger;
        }

        // GET: api/Mail
        [HttpGet]
        public async Task<IActionResult> Get()
      {
          try
          {
              var mails = _service.GetAllMails();
              if (mails.Any())
              {
                  return Ok(mails);
              }
              return NotFound("No emails could be found");
          }
          catch (Exception e)
          {
              _logger.Error(e.StackTrace);
              return NotFound("No emails could be found");
          }
      }

        // GET: api/Mail/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var mailItem = _service.GetById(id);
                if (mailItem == null)
                {
                    return NotFound("The email with given id could not be found.");
                }
                return Ok(mailItem);
            }
            catch (Exception e)
            {
                _logger.Error(e.StackTrace);
                throw;
            }

        }

        // POST: api/Mail
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]MailDto mail, IEnumerable<IFormFile> files)
       {
           try
           {
                if (!string.IsNullOrEmpty(mail.Sender) && mail.Receivers.Count > 0 && !string.IsNullOrEmpty(mail.Body))
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
           catch (Exception e)
           {
                _logger.Error(e.StackTrace);
                throw;
           }

       }

        // PUT: api/Mail/5
        [HttpPut]
        public async Task<IActionResult> Put(AwsMailDto mailDto)
        {
            try
            {
                if (mailDto.BounceType != "permanent")
                {
                    return Ok(mailDto);
                }
                var mail = _service.UpdateMail(mailDto);
                if (mail == null)
                {
                    return NotFound("The email with given external id could not be found.");
                }
                return Ok(mail);
            }
            catch (Exception e)
            {
                _logger.Error(e.StackTrace);
                throw;
            }

        }
    }
}
