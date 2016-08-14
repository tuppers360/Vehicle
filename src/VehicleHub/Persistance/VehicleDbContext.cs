using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using VehicleHub.Core.Models;

namespace VehicleHub.Persistance
{
    public class VehicleDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Mileage> Mileages { get; set; }

        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Vehicle>()
            //    .HasMany(m => m.Mileages)
            //    .WithOne();

            //builder.Entity<Mileage>()
            //    .HasOne(v => v.Vehicle)
            //    .WithMany();

        }
    }
}
