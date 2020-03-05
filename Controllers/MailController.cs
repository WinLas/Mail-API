using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
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

        public MailController(MailDbContext context)
    {
        _context = context;
    }
        // GET: api/Mail
        [HttpGet]
      //  public IEnumerable<Mail> Get()
      public async Task<IActionResult> Get()
       {
            var arr = _context.Mails.ToList();
             return Ok(arr);
        }

        // GET: api/Mail/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Mail mail)
        {
            var dbMail = _context.Mails.FirstOrDefault(m => m.Id.Equals(mail.Id));
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
               // Setup the email recipients.
               var oDestination = new Destination();
               List<string> emailList = new List<string> { value.Receiver };
               oDestination.ToAddresses = emailList;

               // Create the email subject.
               var oSubject = new Content();
               oSubject.Data = "subject";
               
               // Create the email body.
               var oTextBody = new Content();
               string trackingId = Guid.NewGuid().ToString();
               value.TrackerId = trackingId;
               string imageHtml = "<img src='"+ Request.Scheme + "://" + Request.Host + Request.PathBase + Url.Action("getPixel","Track", new {trackingId = trackingId})+"'>";
               oTextBody.Data = value.Body+imageHtml;
               var oBody = new Body();
               oBody.Html = oTextBody;

               // Create and transmit the email to the recipients via Amazon SES.
               var oMessage = new Message();
               oMessage.Body = oBody;
               oMessage.Subject = oSubject;
               SendEmailResponse reply = null;
               var request = new SendEmailRequest();
               request.Source = value.Sender;
               request.Destination = oDestination;
               request.Message = oMessage;
               using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest1))
               {
                    reply = await client.SendEmailAsync(request);
                    value.ExternalId = reply.MessageId;
                    _context.Mails.Update(value);
                    _context.SaveChanges();
               } 
               return Ok(reply);
           }
           return NotFound("The email must have a receiver, sender and a body.");
       }

        // PUT: api/Mail/5
        [HttpPut]
        public async Task<IActionResult> Put(Mail mail)
        {
            var dbMail = _context.Mails.FirstOrDefault(m => m.ExternalId.Equals(mail.ExternalId));
            if (dbMail == null)
            {
                return NotFound("The email with given id could not be found.");
            }
            dbMail.Status = (MailStatus) 2;
            dbMail.ErrorStatus = mail.ErrorStatus;
            _context.Mails.Update(dbMail);
            _context.SaveChanges();
            return Ok(dbMail);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
