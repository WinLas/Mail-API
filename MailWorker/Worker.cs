using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mail_API.Models;
using Mail_API.Models.Db;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MailWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly EmailService _service;

        public Worker(ILogger<Worker> logger, EmailService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await _service.SendUnsentMail();
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "fel");
                }
           

                await Task.Delay(15000, stoppingToken);
            }
        }
    }
}
