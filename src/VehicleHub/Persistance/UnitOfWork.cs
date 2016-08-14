using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleHub.Core;
using VehicleHub.Core.Repositories;
using VehicleHub.Persistance.Repositories;

namespace VehicleHub.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehicleDbContext _context;

        public IVehicleRepository Vehicles { get; private set; }

        public UnitOfWork(VehicleDbContext context)
        {
            _context = context;
            Vehicles = new VehicleRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
