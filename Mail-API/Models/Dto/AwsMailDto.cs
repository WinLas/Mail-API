using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mail_API.Models.Dto
{
    public class AwsMailDto
    {
        public string ExternalId { get; set; }
        public string ErrorStatus { get; set; }
        public string BounceType { get; set; }
    }
}
