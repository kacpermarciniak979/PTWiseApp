using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using PTWiseApp.API.Entities;
using PTWiseApp.Web.Services.Interfaces;

namespace PTWiseApp.Web.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;

        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<Client>>("api/Client/GetClients");
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Client>> GetClientsPagedAsync(int skip, int take, string sort, string search)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<Client>>($"api/Client/GetClientsPaged?skip={skip}&take={take}&sort={sort}&search={search}");
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Client> GetClientByIdAsync(int Id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<Client>($"api/Client/GetClientById?Id={Id}");
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
