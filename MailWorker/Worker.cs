using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mail_API.Models;
using Mail_API.Models.Db;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using Serilog;

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
                    _logger.LogInformation("Email has been sent");
                }
                catch (Exception e)
                {
                    _logger.LogInformation("No emails in queue");
                }
                
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
