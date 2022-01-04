using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-914I9BN;database=DbCoreCamp;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(x => x.Sender)
                .WithMany(x => x.Senders)
                .HasForeignKey(x => x.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Message>()
                .HasOne(x => x.Reciever)
                .WithMany(x => x.Recievers)
                .HasForeignKey(x => x.RecieverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
