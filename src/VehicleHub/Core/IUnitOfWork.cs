using System.Threading.Tasks;
using VehicleHub.Core.Repositories;
using VehicleHub.Persistance.Repositories;

namespace VehicleHub.Core
{
    public interface IUnitOfWork
    {
        IVehicleRepository Vehicles { get; }
        void Complete();
        Task CompleteAsync();
    }
}