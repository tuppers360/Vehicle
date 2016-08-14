using System.Collections.Generic;
using VehicleHub.Core.Models.Enum;

namespace VehicleHub.Core.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Mileages = new List<Mileage>();
        }

        public int Id { get; set; }
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Marked Marked { get; set; }
        public virtual ICollection<Mileage> Mileages { get; set; }
    }
}
