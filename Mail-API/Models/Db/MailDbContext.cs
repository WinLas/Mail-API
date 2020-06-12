using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Mail_API.Models.Db
{
    public class MailDbContext : DbContext
    {
        public MailDbContext(DbContextOptions<MailDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mail> DbMails { get; set; }
        public DbSet<AttachmentFiles> DbFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<Mail>()
                    .HasData(
                        new Mail
                        {
                            Id = i,
                            ExternalId = "Test1",
                            CreatedTime = DateTime.Now,
                            SentTime = DateTime.Now,
                            TrackerId = "FirstTrackerId",
                            OpenTime = DateTime.Now,
                            IPAddress = "FirstIPAddress",
                            Receiver = "robin.eskilsson@winlas.se",
                            Sender = "no-reply@winlas.se",
                            ReplyTo = "FirstReplyTo",
                            Subject = "FirstSubject",
                            Body = "FirstBody",
                        }
                    );
            }

            modelBuilder.Entity<AttachmentFiles>()
                .HasData(
                    new AttachmentFiles
                    {
                        Id = 1,
                        Name = "Attachment.txt",
                        FileBytes = System.IO.File.ReadAllBytes(@"C:\Users\robin.eskilsson\Attachment.txt"),
                        MailId = 1
                    }
                );
    }
    }
}