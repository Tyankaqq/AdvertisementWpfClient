using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AdvertisementWpfClient.Models;

namespace AdvertisementWpfClient.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> GetAverageCostAsync()
        {
            var response = await _httpClient.GetAsync("api/advertisement/average-cost");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<decimal>();
        }

        public async Task<List<AdvertisementOrder>> GetAdvertisementsAboveCostAsync(decimal cost)
        {
            var response = await _httpClient.GetAsync($"api/advertisement/advertisements-above-cost?cost={cost}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<AdvertisementOrder>>();
        }

        public async Task<List<Broadcast>> GetMostPopularBroadcastsAsync()
        {
            var response = await _httpClient.GetAsync("api/advertisement/most-popular-broadcasts");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Broadcast>>();
        }
    }
}
