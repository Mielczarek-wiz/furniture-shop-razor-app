using Microsoft.EntityFrameworkCore;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Data;
using MielczarekFurniture.RestApi.Entities;
using MielczarekFurniture.RestApi.Repositories.Contracts;

namespace MielczarekFurniture.RestApi.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly FurnitureDbContext furnitureDbContext;

        public ProducerRepository(FurnitureDbContext furnitureDbContext)
        {
            this.furnitureDbContext = furnitureDbContext;
        }
        public async Task<IEnumerable<Producer>> GetProducers()
        {
            var producers = await furnitureDbContext.producers.ToListAsync();
            return producers;
        }
        public async Task<Producer> GetProducer(int id)
        {
            var producer = await furnitureDbContext.producers.FindAsync(id);
            return producer;
        }

        public async Task<Producer> AddProducer(ProducerFormDto producerForm)
        {
            if (producerForm != null )
            {
                var result = await furnitureDbContext.producers.AddAsync(new Producer()
                {
                    Name = producerForm.Name,
                    Star = producerForm.Star
                });
                await furnitureDbContext.SaveChangesAsync();
                return result.Entity;

            }
            return null;
        }

        public async Task<Producer> DeleteProducer(int id)
        {
            var producer = await furnitureDbContext.producers.FindAsync(id);
            if (producer != null)
            {
                furnitureDbContext.producers.Remove(producer);
                await furnitureDbContext.SaveChangesAsync();
            }
            return producer;
        }

        public async Task<Producer> UpdateProducer(int id, ProducerFormDto producerForm)
        {
            var oldProducer = await furnitureDbContext.producers.FindAsync(id);

            if (oldProducer != null)
            {
                oldProducer.Name = producerForm.Name;
                oldProducer.Star = producerForm.Star;
                await furnitureDbContext.SaveChangesAsync();
                return oldProducer;
            }
            return null;
        }
    }
}
