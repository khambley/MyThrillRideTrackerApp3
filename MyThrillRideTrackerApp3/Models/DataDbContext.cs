using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyThrillRideTrackerApp3.Models
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Park> Parks { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<MyRide> MyRides { get; set; }
        public DbSet<ImageFileName> ImageFileNames { get; set; }

    }
}
