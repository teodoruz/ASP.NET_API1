using API.Domain.Models;

namespace API.Domain.interfaces.Repository
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);
        Task DeleteAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task<UserModel> GetClientById(string clientId);
        Task<List<UserModel>> ListByFilterAsync(string userId = null, string name = null);
    }
}
