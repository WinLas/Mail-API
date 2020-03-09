using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Mail_API.Models.Db;

namespace Mail_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        readonly FileContentResult pixelResponse;
        private readonly MailDbContext _context;

        public TrackController(FileContentResult pixelResponse, MailDbContext context)
        {
            this.pixelResponse = pixelResponse;
            _context = context;
        }

        public async Task<FileContentResult> getPixel(string trackingId)
        {
            //get request parameters  
            var parameters = Request.Query.Keys.ToDictionary(k => k, k => Request.Query[k]);

            //get request headers  
            var headers = Request.Headers.Keys.ToDictionary(k => k, k => Request.Query[k]);

               await Task.Factory.StartNew((data) =>
            {
                var dataDictionary = data as IDictionary<string, StringValues>;
                var dbMail = _context.Mails.FirstOrDefault(m => m.TrackerId.Equals(trackingId));
                dbMail.OpenTime = DateTime.Now;
                dbMail.Status = MailStatus.Opened;
                _context.Mails.Update(dbMail);
                _context.SaveChanges();

            }, parameters.Union(headers).ToDictionary(k => k.Key, v => v.Value)).ConfigureAwait(false);
            //return pixel  
            return pixelResponse;
        }
    }
}