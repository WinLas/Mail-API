using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mail_API.Models.Db;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MailWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly MailDbContext _db;

        public Worker(ILogger<Worker> logger,MailDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var mail = _db.Mails.FirstOrDefault();
                _logger.LogInformation(mail.ToString());
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
