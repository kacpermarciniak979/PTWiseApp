using PTWiseApp.API.Entities;

namespace PTWiseApp.Web.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(int Id);
    }
}
