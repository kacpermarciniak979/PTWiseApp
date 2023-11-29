using PTWiseApp.API.Entities;


namespace PTWiseApp.Web.Services.Interfaces
{
    public interface ITrainerService
    {
        Task<IEnumerable<Trainer>> GetTrainersAsync();
        Task<Trainer> GetTrainerByIdAsync(int Id);
    }
}
