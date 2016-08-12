using VehicleHub.Models.Enum;

namespace VehicleHub.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
        }

        public int Id { get; set; }
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Marked Marked { get; set; }
    }
}
