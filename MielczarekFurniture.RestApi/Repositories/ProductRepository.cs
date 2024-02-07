using Microsoft.EntityFrameworkCore;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Data;
using MielczarekFurniture.RestApi.Entities;
using MielczarekFurniture.RestApi.Repositories.Contracts;

namespace MielczarekFurniture.RestApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FurnitureDbContext furnitureDbContext;

        public ProductRepository(FurnitureDbContext furnitureDbContext)
        {
            this.furnitureDbContext = furnitureDbContext;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await furnitureDbContext.products.ToListAsync();

            return products;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await furnitureDbContext.products.Where(p => p.Id == id).Include(p => p.Producer).FirstAsync();
            return product;
        }

        public async Task<Product> DeleteItem(int id)
        {
            var item = await furnitureDbContext.products.FindAsync(id);
            if(item != null)
            {
                furnitureDbContext.products.Remove(item);
                await furnitureDbContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<Product> AddItem(ProductFormDto item)
        {
            var producer = await furnitureDbContext.producers.Where(x => x.Name == item.ProducerName).FirstOrDefaultAsync();
            if (item != null && producer != null)
            {
                var result = await furnitureDbContext.products.AddAsync(new Product()
                {
                    Name = item.Name,
                    Description = item.Description,
                    ImageURL = item.ImageURL,
                    Price = item.Price,
                    Producer = producer
                });
                    await furnitureDbContext.SaveChangesAsync();
                    return result.Entity;
                
            }
            return null;
        }

        public async Task<Product> UpdateItem(int id, ProductFormDto item)
        {
            var oldItem = await furnitureDbContext.products.FindAsync(id);
            var producer = await furnitureDbContext.producers.Where(x => x.Name == item.ProducerName).FirstOrDefaultAsync();

            if (oldItem != null && producer != null)
            {
                oldItem.Name = item.Name;
                oldItem.Description = item.Description;
                oldItem.ImageURL = item.ImageURL;
                oldItem.Price = item.Price;
                oldItem.Producer = producer;
                await furnitureDbContext.SaveChangesAsync();
                return oldItem;
            }
            return null;
        }

        public async Task<IEnumerable<Product>> GetItemsByName(string name)
        {
            var products = await furnitureDbContext.products.Where(p => p.Name.Contains(name.ToLower())).ToListAsync();

            return products;
        }
    }
}
