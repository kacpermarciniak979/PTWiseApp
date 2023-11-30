using Microsoft.AspNetCore.Mvc;
using PTWiseApp.API.Entities;
using PTWiseApp.API.Services;

namespace PTWiseApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkoutController : Controller
    {
        private readonly WorkoutService workoutService;

        public WorkoutController(WorkoutService workoutService)
        {
            this.workoutService = workoutService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkouts()
        {
            try
            {
                var result = await workoutService.GetWorkoutsAsync();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            } catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult<Workout>> GetWorkoutByIdAsync([FromQuery]int Id)
        {
            try
            {
                var result = await workoutService.GetWorkoutByIdAsync(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            } catch(Exception ex)
            {
                throw;
            }
        }
    }
}
