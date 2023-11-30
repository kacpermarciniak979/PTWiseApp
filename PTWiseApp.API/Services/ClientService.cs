using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Data;
using PTWiseApp.API.Entities;

namespace PTWiseApp.API.Services
{
    public class ClientService
    {
        private readonly PTWiseDbContext pTWiseDbContext;

        public ClientService(PTWiseDbContext pTWiseDbContext)
        {
            this.pTWiseDbContext = pTWiseDbContext;
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            var result = await pTWiseDbContext.Clients.ToListAsync();
            return result;
        }

        public async Task<Client> GetClientByIdAsync(int Id)
        {
            var result = await pTWiseDbContext.Clients
                .Include(x => x.Trainer)
                .FirstOrDefaultAsync(x => x.Id == Id);
            return result;
        }
    }
}
