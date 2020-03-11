using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Mail_API.Entities;
using Microsoft.Extensions.Configuration;
using Serilog;


namespace Mail_API
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
                Log.Information("Mail-Api starting");
                CreateHostBuilder(args).Build().MigrateDatabase().Run();
            }
            catch (Exception ex)
            {
                Log.Information(ex, "Mail-Api failed to start.");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
           
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    } 
}
