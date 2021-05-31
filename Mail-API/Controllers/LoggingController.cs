using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public string GetIpAddressOfClient()
        {
            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
            return ip;
        }

        [HttpPost]
        public async Task<IActionResult> LoadData()
        {
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            int recordsTotal = 0;
            var dbData = _context.Mails.AsQueryable();
         
            // Search Value from (Search box)  
            var searchValue = Request.Form["search"].FirstOrDefault();

            //Paging Size (10, 20, 50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            
            int skip = start != null ? Convert.ToInt32(start) : 0;
           
            //Search  
            if (!string.IsNullOrEmpty(searchValue))
            {
                dbData = dbData.Where(m =>
                    m.Receiver.Contains(searchValue) || m.Subject.Contains(searchValue) ||
                    m.Sender.Contains(searchValue) || m.Body.Contains(searchValue));
            }
            
            recordsTotal = dbData.Count();

            var data = dbData.Select(m => new { m.Id, m.SentTime, m.Receiver, m.Sender, m.Subject, m.Status }).OrderByDescending(m => m.Id).Skip(skip).Take(pageSize).ToList();

            return Json(new { draw = draw, recordsTotal = recordsTotal, recordsFiltered = recordsTotal, data = data });
        }
    }
}
