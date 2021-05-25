using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Mail_API.Models.Dto
{
    public class MailDto
    {
        public List<string> Receivers { get; set; } = new List<string>();
        public string Sender { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }              
}
