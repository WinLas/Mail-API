using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mail_API.Models.Db
{
    public static class ModelBuilderExtensions
    {

        // Extension method to keep OnModelCreating method clean
        public static void Seed(this ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<Mail>().HasData(
             //       new Mail
             //       {
                      
             //       });
         /*   modelBuilder.Entity<AttachmentFiles>()
                .HasData(
                    new AttachmentFiles
                    {
                        Id = 1,
                        Name = "Attachment.txt",
                        fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\robin.eskilsson\Attachment.txt"),
                        MailId = 1
                    });  */
        }
    }
}
