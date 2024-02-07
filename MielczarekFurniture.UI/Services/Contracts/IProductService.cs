using MielczarekFurniture.Models.Dtos;

namespace MielczarekFurniture.UI.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        //Task<IEnumerable<ProductDto>> GetItemsByName(string name);
        Task<ProductDto> GetItem(int id);
        Task<ProductDto> AddItem(ProductFormDto item);
        Task<ProductDto> DeleteItem(int id);
        Task<ProductDto> ModifyItem(int id, ProductFormDto item);

    }
}
