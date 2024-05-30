using Deedforge.Shared.Compendium;
using System.Net.Http.Json;

namespace Deedforge.Client.Services
{
    public class DataFetchServiceProxy : IDataFetchService
    {
        private readonly HttpClient _httpClient;

        public DataFetchServiceProxy(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CompendiumData> GetCompendiumData()
        {
            var response = await _httpClient.GetFromJsonAsync<CompendiumData>("api/compendium");

            return response;
        }
    }
}
