using AutoCare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkingProject11.Models
{
    public class ParkingDbContext : IdentityDbContext<ApplicationUser>
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FeedBacks> FeedBacks { get; set; }

        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Slot> Slots { get; set; }

    }
}
   
