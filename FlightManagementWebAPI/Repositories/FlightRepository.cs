using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class FlightRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public FlightRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }

        public List<Flight> GetFlights()
        {
            return _airportSystemContext.Flights.ToList();
        }
    }
}
