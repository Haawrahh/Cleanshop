using Cleanshop.domain.Entities;

namespace Cleanshop.domain.Interfaces
{
    public interface IProductRepository
    {
       Task<List<Product>> GetAllAsync();
       Task<Product?> GetByIdAsync(int id);
         Task<Product> CreateAsync(Product product);
         Task<bool> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<Product> AddAsync(Product product);
    }
}
