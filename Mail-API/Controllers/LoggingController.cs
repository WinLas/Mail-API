using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mail_API.Models.Db;
using Newtonsoft.Json;


namespace Mail_API.Controllers
{
    public class LoggingController : Controller
    {
        private readonly MailDbContext _context;

        public LoggingController(MailDbContext context)
        {
            _context = context;
        }
       
        
        public async Task<IActionResult> Index()
        {
            ViewBag.a1 = "a1";
            ViewBag.b1 = "b1";
            ViewBag.c1 = "c1";
            ViewBag.d1 = "d1";
            return View(await _context.DbMails.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> LoadData()
        {
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            int recordsTotal = 0;
            var dbData = _context.DbMails.AsQueryable();
            recordsTotal = dbData.Count();
            var recordsFiltered = dbData.Count();
            var jsonData = JsonConvert.SerializeObject(dbData);
            // Sort Column Name  
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

            // Sort Column Direction (asc, desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10, 20, 50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;

            int skip = start != null ? Convert.ToInt32(start) : 0;
            // getting all Customer data  

            var data = dbData.Skip(skip).Take(pageSize).ToList();
            //returnera draw, dbdata, recordsTotal och recordsFiltered i jsonformat
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }
    }
}
