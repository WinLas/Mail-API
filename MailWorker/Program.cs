using System;
using Mail_API.Models;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;


namespace MailWorker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

                  Log.Logger = new LoggerConfiguration()
                  .ReadFrom.Configuration(configuration)
                  .CreateLogger();
                  
            try
            {
                Log.Information("Worker service starting");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Worker service failed to start");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    var optionsBuilder = new DbContextOptionsBuilder<MailDbContext>();
                    optionsBuilder.UseSqlServer(hostContext.Configuration.GetSection("ConnectionStrings").GetSection("sqlConnection").Value);
                    services.AddSingleton(new EmailService(new MailDbContext(optionsBuilder.Options)));
                });

    }//hostContext.Configuration.GetSection("sqlConnection").ToString()
}
