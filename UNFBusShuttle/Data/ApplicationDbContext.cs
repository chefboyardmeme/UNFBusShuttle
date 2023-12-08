using Microsoft.EntityFrameworkCore;
using UNFBusShuttle.Models;

namespace UNFBusShuttle.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        
    }
}
