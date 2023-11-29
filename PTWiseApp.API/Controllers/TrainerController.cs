using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PTWiseApp.API.Entities;
using PTWiseApp.API.Services;

namespace PTWiseApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly TrainerService trainerService;

        public TrainerController(TrainerService _trainerService)
        {
            trainerService = _trainerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trainer>>> GetTrainers()
        {
            try
            {
                var result = await trainerService.GetTrainersAsync();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                //return null;
                throw;
            }
        }

    }
}
