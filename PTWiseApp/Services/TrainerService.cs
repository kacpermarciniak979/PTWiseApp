using Microsoft.AspNetCore.Http.HttpResults;
using PTWiseApp.API.Entities;
using PTWiseApp.Web.Services.Interfaces;

namespace PTWiseApp.Web.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly HttpClient _httpClient;

        public TrainerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Trainer>> GetTrainersAsync()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<Trainer>>("api/Trainer/GetTrainers");
                return result;
            } catch
            {
                return null;
            }
        }
    }
}
