using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleHub.Core.Models;
using VehicleHub.Core.Models.Enum;

namespace VehicleHub.Core.Dtos
{
    public class VehicleDto
    {
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Marked Marked { get; set; }
        public ICollection<MileageDto> Mileages { get; set; }
    }
}
