using API.Domain.Models;

namespace API.Domain.interfaces.Repository
{
    public interface IClientRepoditory
    {
        Task CreateAsync(ClientModel client);
        Task DeleteAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task<ClientModel> GetClientById(string clientId);
        Task<List<ClientModel>> ListByFilterAsync(string clientId = null, string name = null);

    }
}
