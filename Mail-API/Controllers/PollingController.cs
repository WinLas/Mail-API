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
            var dbMail = _context.DbMails.Select(m => new { m.Id, m.Status }).Where(m => polling.Id.Contains(m.Id));
            return Ok(dbMail);
        }
    }
}
