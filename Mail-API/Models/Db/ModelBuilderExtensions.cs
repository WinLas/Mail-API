using Microsoft.EntityFrameworkCore;

namespace Mail_API.Models.Db
{
    public static class ModelBuilderExtensions
    {

        // Extension method to keep OnModelCreating method clean
        public static void Seed(this ModelBuilder modelBuilder)
        {
         // add data here, then add-migration and update-database in PMC.
        }
    }
}
