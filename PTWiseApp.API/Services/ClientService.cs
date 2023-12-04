using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Data;
using PTWiseApp.API.Entities;
using System.Xml.Linq;

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

        public async Task<List<Client>> GetClientsPagedAsync(int skip, int take, string sort, string search)
        {
            var clients = await pTWiseDbContext.Clients.Include(c => c.Trainer).Include(c => c.Appointments).ToListAsync();

            clients = clients.Where(client =>
            {
                if (string.IsNullOrWhiteSpace(search))
                    return true;
                if (client.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (client.LastName.Contains(search, StringComparison.OrdinalIgnoreCase))
                    return true;
                if ($"{client.TelephoneNumber} {client.DateOfBirth} {client.EmailAddress}".Contains(search))
                    return true;
                return false;
            }).ToList();

            var pagedClients = clients.Skip(skip).Take(take).ToList();

            return pagedClients;
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
