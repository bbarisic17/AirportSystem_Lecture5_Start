using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class FlightService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl= "https://localhost:44334/api/Flight";
        public FlightService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Flight>> GetFlights()
        {
            return await _httpClient.GetFromJsonAsync<List<Flight>>(BaseApiUrl);
        }
    }
}
