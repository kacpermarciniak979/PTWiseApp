using PTWiseApp.API.Entities;
using PTWiseApp.Web.Services.Interfaces;
using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;

namespace PTWiseApp.Web.Services
{
	public class WorkoutService : IWorkoutService
	{
		private readonly HttpClient httpClient;

        public WorkoutService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Workout>> GetWorkoutsAsync()
        {
            try
            {

                var result = await httpClient.GetFromJsonAsync<IEnumerable<Workout>>("api/Workout/GetWorkouts");
                return result;
            }
            catch (Exception)
            {
                throw;
                return null;
            }
        }

        public async Task<Workout> GetWorkoutByIdAsync(int Id)
        {
            try
            {
                var result = await httpClient.GetFromJsonAsync<Workout>($"api/Workout/GetWorkoutById?Id={Id}");
                return result;
            } catch (Exception)
            {
                throw;
                return null;
            }
        }
    }
}
