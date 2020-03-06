using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace MailWorker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    var optionsBuilder = new DbContextOptionsBuilder<MailDbContext>();
                    optionsBuilder.UseSqlServer(hostContext.Configuration.GetSection("connectionStrings").GetSection("sqlConnection").Value);
                    services.AddSingleton(new MailDbContext(optionsBuilder.Options));
                });

    }//hostContext.Configuration.GetSection("sqlConnection").ToString()
}
