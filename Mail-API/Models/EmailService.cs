using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

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
            if (mail.SentTime == null)
            {
                await SendMail(mail);
               // Console.WriteLine("Email has been sent");
            }
            else
            {
               
            }
        }
        private static BodyBuilder GetMessageBody(Mail mail)
        {
            var body = new BodyBuilder()
            {

                HtmlBody = mail.Body,
            };
            body.Attachments.Add(@"c:\Users\robin.eskilsson\Attachment.txt");
            return body;
        }

        private static MimeMessage GetMessage(Mail mail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("NoReply", mail.Sender));
            message.To.Add(new MailboxAddress(string.Empty, mail.Receiver));
            message.Subject = "subject";

            message.Body = GetMessageBody(mail).ToMessageBody();
            return message;
        }

        private static MemoryStream GetMessageStream(Mail mail)
        {
            var stream = new MemoryStream();
            GetMessage(mail).WriteTo(stream);
            return stream;
        }


        public async Task<Mail> SendMail(Mail mail)
        {
            SendRawEmailResponse reply = null;

            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest1))
            {
                var sendRequest = new SendRawEmailRequest{RawMessage = new RawMessage(GetMessageStream(mail))};
                reply = await client.SendRawEmailAsync(sendRequest);
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
