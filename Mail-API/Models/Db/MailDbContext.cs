using Microsoft.EntityFrameworkCore;


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
            modelBuilder.Seed();
        }
    }
}