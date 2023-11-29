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

        public async Task<Trainer> GetTrainerByIdAsync(int Id)
        {
            try
            {
                // https://localhost:7155/                                 api/Trainer/GetTrainerById?Id=1
                var result = await _httpClient.GetFromJsonAsync<Trainer>($"api/Trainer/GetTrainerById?Id={Id}");
                return result;
            } catch
            {
                return null;
            }
        }
    }
}
