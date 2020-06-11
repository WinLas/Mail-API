using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mail_API.Models.Db;

namespace Mail_API.Controllers
{
    public class LoggingController : Controller
    {
        private readonly MailDbContext _context;

        public LoggingController(MailDbContext context)
        {
            _context = context;
        }

        // GET: Logging
        public async Task<IActionResult> Index()
        {
            return View(await _context.DbMails.ToListAsync());
        }
    }
}
