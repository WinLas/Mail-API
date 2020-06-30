using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mail_API.Models.Db
{
    public class Polling
    {
        public int[] Id { get; set; }
        public MailStatus Status { get; set; }
    }
}
