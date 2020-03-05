using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Net.Mail;
using System.Threading.Channels;

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

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Body) && !string.IsNullOrEmpty(Receiver) && !string.IsNullOrEmpty(Sender);
        }


        /*  public bool validate()
          {
              //Ny funktion för validering av fält
              //Validera CreatedTime inte större än now() - är createdtime null sätt den till now
              //Hämta IP-adressen från anropet och spara den till IPAdress
              //Validera mailaddresserna
              return true;
          }
          */
    }




}

namespace Mail_API
{
    public enum MailStatus
    {
        Unsent = 0, Sent = 1, Error = 2, Opened = 3, Invalid
    }
}