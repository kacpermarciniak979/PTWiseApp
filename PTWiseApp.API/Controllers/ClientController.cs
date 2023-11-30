using Microsoft.AspNetCore.Mvc;
using PTWiseApp.API.Entities;
using PTWiseApp.API.Services;

namespace PTWiseApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly ClientService clientService;

        public ClientController(ClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            try
            {
                var result = await clientService.GetClientsAsync();
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

        [HttpGet]
        public async Task<ActionResult<Client>> GetClientByIdAsync([FromQuery] int Id)
        {
            try
            {
                var result = await clientService.GetClientByIdAsync(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
