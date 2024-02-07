using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Entities;

namespace MielczarekFurniture.RestApi.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<Product>> GetItemsByName(string name);
        Task<Product> GetItem(int id);

        Task<Product> DeleteItem(int id);
        Task<Product> AddItem(ProductFormDto item);
        Task<Product> UpdateItem(int id, ProductFormDto item);
    }
}
