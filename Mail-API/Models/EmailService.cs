using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace Mail_API.Models
{
    public class EmailService
    {
        private readonly MailDbContext _context;

        public EmailService(MailDbContext context)
        {
            _context = context;
        }

        public async Task AddMail (Mail mail)
        {
            _context.Mails.Add(mail);
            _context.SaveChanges();
        }

        public async Task SendUnsentMail()
        {
            var mail = _context.Mails.FirstOrDefault(m => m.SentTime == null);
            if (mail == null)
            {

            }
            else
            {
                await SendMail(mail);
            }
        }
        public async Task<Mail> SendMail(Mail mail)
        {
            // Setup the email recipients.
            var oDestination = new Destination();
            List<string> emailList = new List<string> { mail.Receiver };
            oDestination.ToAddresses = emailList;

            // Create the email subject.
            var oSubject = new Content();
            oSubject.Data = "subject";

            // Create the email body.
            var oTextBody = new Content();
            oTextBody.Data = mail.Body;
            var oBody = new Body();
            oBody.Html = oTextBody;

            // Create and transmit the email to the recipients via Amazon SES.
            var oMessage = new Message();
            oMessage.Body = oBody;
            oMessage.Subject = oSubject;
            SendEmailResponse reply = null;
            var request = new SendEmailRequest();
            request.Source = mail.Sender;
            request.Destination = oDestination;
            request.Message = oMessage;
            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest1))
            {
                reply = await client.SendEmailAsync(request);
                mail.ExternalId = reply.MessageId;
                mail.SentTime = DateTime.Now;
                mail.Status = MailStatus.Sent;
                _context.Mails.Update(mail);
                _context.SaveChanges();
            }
            return mail;
        }

        public IEnumerable<Mail> GetAllMails()
        {
            var allMails = _context.Mails.OrderByDescending(m => m.CreatedTime).Take(100).ToList();
            return allMails;
        }

        public Mail GetById(int id)
        { 
            var mailItem = _context.Mails.Find(id);
            return mailItem;
        }

        public Mail UpdateMail(Mail mail)
        {
            var dbMail = _context.Mails.FirstOrDefault(m => m.ExternalId.Equals(mail.ExternalId));
            dbMail.Status = (MailStatus)2;
            dbMail.ErrorStatus = mail.ErrorStatus;
            _context.Mails.Update(dbMail);
            _context.SaveChanges();
            return dbMail;
        }
    }
}
