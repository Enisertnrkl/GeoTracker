using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeoTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=10.147.17.3;User Id=enis.ertnrkl;Password=402624;Database=GeoTracker;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}
