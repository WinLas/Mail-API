using Mail_API;
using Mail_API.Models.Db;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail_Api.IntegrationTests
{
   public class TestingWebAppFactory<T> : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                //Remove MailDbContext registration from startup class. 
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<MailDbContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }
                //adding in memory database support to DI container via ServiceCollection class
                var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

                // Adding database context to service container and instruct to use IM database. 
                services.AddDbContext<MailDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDatabaseTest");
                    options.UseInternalServiceProvider(serviceProvider);
                });
                var sp = services.BuildServiceProvider();

                // Ensuring we seed data from MailDbContext class
                using (var scope = sp.CreateScope())
                {
                    using (var appContext = scope.ServiceProvider.GetRequiredService<MailDbContext>())
                    {
                        try
                        {
                            appContext.Database.EnsureCreated();
                        
                        }
                        catch(Exception ex)
                        {
                            //log errors 
                            Console.WriteLine("There was an exception {0}", ex);
                            throw;
                        }
                    }
                }
            });
        }
    }
}
