using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleHub.Core.Models;

namespace VehicleHub.Core.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        IEnumerable<Vehicle> GetAllVehiclesWithMileages();
        Task<IEnumerable<Vehicle>> GetAllVehiclesWithMileagesAsync();
    }
}