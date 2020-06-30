using System;
using System.Threading;
using System.Threading.Tasks;
using Mail_API.Models;
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
