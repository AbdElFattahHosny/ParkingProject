using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ParkingProject.Models
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {

        }
     
        public DbSet<Area> Areas { get; set; }
        public DbSet<BusySlots> BusySlots { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FeedBacks> FeedBacks { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Slot> Slots { get; set; }

        public  DbSet<Role> Roles { get; set; }

        public  DbSet<Users> Users { get; set; }
    }
}
   
