using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Mail_API.Models.Db;
using Mail_API.Models.Dto;
using Microsoft.EntityFrameworkCore;
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
            if (mail != null)
            {
                if (mail.SentTime == null)
                {
                    await SendMail(mail);
                }
            }
        }

        private BodyBuilder GetMessageBody(Mail mail)
        {
            var body = new BodyBuilder()
            {
                HtmlBody = mail.Body,
            };
            var files = GetFilesForMail(mail.Id);
            if (files.Count > 0)
            {
                foreach (AttachmentFiles file in files)
                {
                    try
                    {
                        var fileBytes = File.ReadAllBytes(file.FilePath);
                        body.Attachments.Add(file.Name, fileBytes);
                    }
                    catch (Exception e)
                    {
                        // logga fel 
                    }

                }
            }
         
            return body;
        }

        private MimeMessage GetMessage(Mail mail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("WinLas", mail.Sender));
            message.To.Add(new MailboxAddress(string.Empty, mail.Receiver));
            message.Subject = "subject";
            message.Body = GetMessageBody(mail).ToMessageBody();
            return message;
        }

        private MemoryStream GetMessageStream(Mail mail)
        {
            var stream = new MemoryStream();
            GetMessage(mail).WriteTo(stream);
            return stream;
        }

        public AttachmentFiles GetFile(int fileId)
        {
            return _context.Files.FirstOrDefault(x=>x.Id == fileId);
        }

        public List<AttachmentFiles> GetFilesForMail(int mailId)
        {
            var files = _context.MailFile.Where(x => x.MailId == mailId).ToList();
            List<AttachmentFiles> attachmentFiles = new List<AttachmentFiles>();
            foreach (var mailfile in files)
            {
                var file = GetFile(mailfile.FileId);
                attachmentFiles.Add(file);
            }
            return attachmentFiles.ToList();
        }

        public async Task<Mail> SendMail(Mail mail)
        {
            SendRawEmailResponse reply = new SendRawEmailResponse();

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

        internal void SaveAttachment(AttachmentFiles file)
        {
            _context.Files.Add(file);
            _context.SaveChanges();
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
            if (dbMail != null)
            {
                if (!string.IsNullOrEmpty(mail.ExternalId) && dbMail.ExternalId == mail.ExternalId)
                {
                    dbMail.Status = (MailStatus)2;
                    dbMail.ErrorStatus = mail.ErrorStatus;
                    _context.Mails.Update(dbMail);
                    _context.SaveChanges();

                    return dbMail;
                }
            }
            return null;
        }

        internal void SaveMailIdFileId(MailIdFileId mailFile)
        {
            _context.MailFile.Add(mailFile);
            _context.SaveChanges();
        }
    }
}
