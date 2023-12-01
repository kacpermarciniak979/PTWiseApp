using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Data;
using PTWiseApp.API.Entities;

namespace PTWiseApp.API.Services
{
	public class WorkoutService
	{
		private readonly PTWiseDbContext pTWiseDbContext;

        public WorkoutService(PTWiseDbContext pTWiseDbContext)
        {
            this.pTWiseDbContext = pTWiseDbContext;
        }

        public async Task<List<Workout>> GetWorkoutsAsync()
        {
            var result = await pTWiseDbContext.Workouts
                .Include(w => w.Exercises)
                .ToListAsync();
            return result;
        }

        public async Task<Workout> GetWorkoutByIdAsync(int Id)
        {
            var result = await pTWiseDbContext.Workouts
                .Include(w => w.Exercises)
                .FirstOrDefaultAsync(x => x.Id == Id);
            return result;
        }
    }
}
