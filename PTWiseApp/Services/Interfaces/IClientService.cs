using PTWiseApp.API.Entities;

namespace PTWiseApp.Web.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(int Id);
        Task<IEnumerable<Client>> GetClientsPagedAsync(int skip, int take, string sort, string search);
    }
}
