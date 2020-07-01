using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Mail_API.Models.Db
{
    public class Mail
    {

        public int Id { get; set; }
        public string ExternalId { get; set; }
        public MailStatus Status { get; set; } = MailStatus.Unsent;
        public DateTime CreatedTime { get; set; }
        public DateTime? SentTime { get; set; }
        public string TrackerId { get; set; }
        public DateTime? OpenTime { get; set; }
        public string IPAddress { get; set; }
        public string Receiver { get; set; }
        public string Sender { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ErrorStatus { get; set; }
        public List<AttachmentFiles> Files { get; set; }

        public void SetPixel(string url)
        {
            string trackingId = Guid.NewGuid().ToString();
            TrackerId = trackingId;
            string imageHtml = "<img src='" + url + "/api/track/" + trackingId + "'>";
            Body = Body + imageHtml;
        }
        public bool ValidateEmail(string emailAddress)
        {
            try
            {
                var mailAddress = new MailAddress(emailAddress);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Body) && ValidateEmail(Receiver) && ValidateEmail(Sender);
        }
    }
}

namespace Mail_API
{
    public enum MailStatus
    {
        Unsent = 0, Sent = 1, Error = 2, Opened = 3, Invalid = 4
    }
}