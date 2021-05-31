using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mail_API.Models.Db;
using MimeKit;
using Newtonsoft.Json;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
    
    public class PollingController : ControllerBase
    {
        private readonly MailDbContext _context;

        public PollingController(MailDbContext context)
        {
            _context = context;
        }

        // POST: api/Polling
        [HttpPost]
        public async Task<IActionResult> ShowStatus([FromBody] Polling polling)
        {
            var dbMail = _context.Mails.Select(m => new { m.Id, m.Status,m.ErrorStatus }).Where(m => polling.Id.Contains(m.Id)).ToList();

                if (polling.Id.Length != 0 || dbMail.Any(m => polling.Id.Contains(m.Id)))
                {

                    for (int i = 0; i <= polling.Id.Length - 1; i++)
                    {
                        var findId = dbMail.Where(m => polling.Id[i].Equals(m.Id));

                        if (!findId.Any())
                        {
                            dbMail.Add(new { Id = polling.Id[i], Status = MailStatus.Invalid, ErrorStatus = "Invalid mail Id" });
                        }
                    }

                    return Ok(dbMail);
                }
                return NotFound("You have to enter a valid mail Id");
        }
    }
}
