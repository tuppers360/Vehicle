using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleHub.Core.Models;
using VehicleHub.Core.Repositories;

namespace VehicleHub.Persistance.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext _context;

        public VehicleRepository(VehicleDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public IEnumerable<Vehicle> GetAllVehiclesWithMileages()
        {
            return _context.Vehicles.Include(v => v.Mileages).ToList();
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesWithMileagesAsync()
        {
            return await _context.Vehicles.Include(v => v.Mileages).ToListAsync();
        }
    }
}
