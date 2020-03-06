using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Mail_API;
using Mail_API.Models.Db;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MailWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly MailDbContext _db;

        public Worker(ILogger<Worker> logger,MailDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var mail = _db.Mails.FirstOrDefault(m=>m.SentTime == null);
                if (mail == null)
                {
                    _logger.LogInformation("No emails in queue");
                }
                else
                {
                    // Setup the email recipients.
                    var oDestination = new Destination();
                    List<string> emailList = new List<string> {mail.Receiver};
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
                        _db.Mails.Update(mail);
                        _db.SaveChanges();
                    }
                    _logger.LogInformation("Email has been sent to {0}",mail.Receiver);
                }

                await Task.Delay(15000, stoppingToken);
            }
        }
    }
}
