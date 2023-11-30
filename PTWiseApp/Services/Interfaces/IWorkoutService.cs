using PTWiseApp.API.Entities;

namespace PTWiseApp.Web.Services.Interfaces
{
	public interface IWorkoutService
	{
		Task<IEnumerable<Workout>> GetWorkoutsAsync();
		Task<Workout> GetWorkoutByIdAsync(int Id);
	}
}
