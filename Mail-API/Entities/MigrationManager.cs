using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Mail_API.Entities
{
    public static class MigrationManager
    {
        //Start all required migrations and seed all the required data atm in the database when the application starts. 
        //call the Migrate method for the migration execution
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var mailContext = scope.ServiceProvider.GetRequiredService<MailDbContext>())
                {
                    try
                    {
                        mailContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        //Log errors or do anything needed
                        throw;
                    }
                }
            }

            return host;
        }
    }
}