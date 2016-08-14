using System;
using System.Collections.Generic;
using System.Linq;
using VehicleHub.Core.Models;
using VehicleHub.Core.Models.Enum;

namespace VehicleHub.Persistance
{
    public class VehicleDbInitialiser
    {
        private static VehicleDbContext _context;

        public static void Initialise(IServiceProvider serviceProvider)
        {
            _context = (VehicleDbContext) serviceProvider.GetService(typeof(VehicleDbContext));
            InitialiseGenre();
        }

        private static void InitialiseGenre()
        {
            if (!_context.Vehicles.Any())
            {

                _context.Vehicles.AddRange(
                    new Vehicle
                    {
                        Registration = "PO11SBA",
                        Make = "Hyundai",
                        Model = "i30",
                        Marked = Marked.Liveried
                    },
                    new Vehicle
                    {
                        Registration = "PO11SCA",
                        Make = "Hyundai",
                        Model = "i30",
                        Marked = Marked.Liveried
                    },
                    new Vehicle
                    {
                        Registration = "PO11SCB",
                        Make = "Hyundai",
                        Model = "i30",
                        Marked = Marked.Liveried
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
            }

            if (!_context.Mileages.Any())
            {
                _context.Mileages.AddRange(
                new Mileage
                {
                    VehicleId = 1,
                    MileageDate = DateTime.Now,
                    RecordedMileage = "123456",
                },
                new Mileage
                {
                    VehicleId = 2,
                    MileageDate = DateTime.Now,
                    RecordedMileage = "123456",
                },
                new Mileage
                {
                    VehicleId = 3,
                    MileageDate = DateTime.Now,
                    RecordedMileage = "0",
                },
                new Mileage
                {
                    VehicleId = 4,
                    MileageDate = DateTime.Now,
                    RecordedMileage = "0",
                },
                new Mileage
                {
                    VehicleId = 5,
                    MileageDate = DateTime.Now,
                    RecordedMileage = "0",
                }
            );
            }

            _context.SaveChanges();
        }
    }
}
