using System;
using System.Net;
using System.Net.Mail;

namespace Mail_API.Models
{
    public class Mail
    {
        public string Id { get; set; }
        public string ExternalId { get; set; }
        public MailStatus Status { get; set; } = MailStatus.Unsent;
        public DateTime CreatedTime { get; set; }
        public DateTime? SentTime { get; set; }
        public string TrackerId { get; set; }
        public DateTime? OpenTime { get; set; }
        public string IPAdress { get; set; }
        public MailAddress Receiver { get; set; }
        public MailAddress Sender { get; set; }
        public MailAddress? ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool validate()
        {
            //Ny funktion för validering av fält
            //Validera CreatedTime inte större än now() - är createdtime null sätt den till now
            //Hämta IP-adressen från anropet och spara den till IPAdress
            return true;
        }

    }


    

}

namespace Mail_API
{
    public enum MailStatus
    {
        Unsent=0,Sent=1,Error=2,Opened=3,Invalid
    }
}