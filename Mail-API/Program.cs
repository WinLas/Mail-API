using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Mail_API.Entities;
using Microsoft.Extensions.Configuration;


namespace Mail_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            try
            {
                CreateHostBuilder(args).Build().MigrateDatabase().Run();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
            }
           
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    } 
}
