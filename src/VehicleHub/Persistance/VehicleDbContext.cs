using Microsoft.EntityFrameworkCore;
using VehicleHub.Models;

namespace VehicleHub.Persistance
{
    public class VehicleDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
