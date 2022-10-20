using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EFCore
{
    public class TurContext:IdentityDbContext<AppUser,AppRole,int> //DbContext'ten kalıtılan sınıf identity kütüphanesi eklendikten sonra bub şekilde değişiklik yapılmaya başlandı . Yeni oluşturulan AppRole ve AppUser entityleri için aşağıda olduğu gibi DbSet<> tanımlamaya gerek yok
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1109MN6F\\SQLEXPRESS;database=TourProjectDb;integrated security=true;");

            //veritabanı bağlantılarıı sağlandı 
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Newsletter> Newsletters { get; set; }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=TurDB");
        //}
    }
}
