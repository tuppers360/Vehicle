using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleHub.Models;
using VehicleHub.Models.Enum;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleHub.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return new List<Vehicle>
            {
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
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
