using System;

namespace VehicleHub.Core.Models
{
    public class Mileage
    {
        public int Id { get; set; }
        public DateTime MileageDate { get; set; }
        public string RecordedMileage { get; set; }

        //Navigation Properties
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
