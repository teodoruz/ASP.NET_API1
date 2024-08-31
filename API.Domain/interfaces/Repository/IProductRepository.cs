using API.Domain.Models;

namespace API.Domain.interfaces.Repository
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel product);
        Task DeleteAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task<ProductModel> GetClientById(string clientId);
        Task<List<ProductModel>> ListByFilterAsync(string ProductId = null, string description = null);
    }
}
