using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VehicleHub.Core;
using VehicleHub.Core.Dtos;
using VehicleHub.Core.Models;
using VehicleHub.Persistance;
using VehicleHub.Persistance.Repositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleHub.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public IEnumerable<Vehicle> Get()
        //{
        //    var query = _unitOfWork.Vehicles.GetAllVehicles()
        //        .ToList();

        //    if (query == null) throw new ArgumentNullException(nameof(query));

        //    return query;
        //}
        // GET: api/values
        [HttpGet]
        public IEnumerable<VehicleDto> Get()
        {
            var query = _unitOfWork.Vehicles.GetAllVehiclesWithMileages()
                .Select(v => new VehicleDto
                {
                    Registration = v.Registration,
                    Make = v.Make,
                    Model = v.Model,
                    Marked = v.Marked,
                    Mileages = v.Mileages.Select(m => new MileageDto
                        {
                            MileageDate = m.MileageDate,
                            RecordedMileage = m.RecordedMileage
                        })
                        .ToList(),
                })
                .ToList();

            if (query == null) throw new ArgumentNullException(nameof(query));

            return query.AsEnumerable();
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
