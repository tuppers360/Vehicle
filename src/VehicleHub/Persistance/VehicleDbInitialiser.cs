using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleHub.Models;
using VehicleHub.Models.Enum;

namespace VehicleHub.Persistance
{
    public class VehicleDbInitialiser
    {
        private static VehicleDbContext _context;

        public static void Initialise(IServiceProvider serviceProvider)
        {
            _context = (VehicleDbContext)serviceProvider.GetService(typeof(VehicleDbContext));
            InitialiseGenre();
        }

        private static void InitialiseGenre()
        {
            if (_context.Vehicles.Any()) return;

            _context.Vehicles.AddRange(
                new Vehicle
                {
                    Registration = "PO11SBA",
                    Make = "Hyundai",
                    Model = "i30",
                    Marked = Marked.Liveried,
                },
                new Vehicle
                {
                    Registration = "PO11SCA",
                    Make = "Hyundai",
                    Model = "i30",
                    Marked = Marked.Liveried,
                },
                new Vehicle
                {
                    Registration = "PO11SCB",
                    Make = "Hyundai",
                    Model = "i30",
                    Marked = Marked.Liveried,
                },
                new Vehicle
                {
                    Registration = "PO11SDA",
                    Make = "Hyundai",
                    Model = "i30",
                    Marked = Marked.Liveried
                },
                new Vehicle
                {
                    Registration = "PO11SDB",
                    Make = "Hyundai",
                    Model = "i30",
                    Marked = Marked.Liveried
                }
            );

            _context.SaveChanges();
        }
    }
}
