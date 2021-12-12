using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly FlightRepository _flightRepository;
        public FlightController(FlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        [HttpGet]
        public IActionResult GetFlights()
        {
            try
            {
                var flights = _flightRepository.GetFlights();
                return Ok(flights);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
