using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Entities;

namespace MielczarekFurniture.RestApi.Repositories.Contracts
{
    public interface IProducerRepository
    {
        Task<IEnumerable<Producer>> GetProducers();
        Task<Producer> GetProducer(int id);
        Task<Producer> AddProducer(ProducerFormDto producerForm);
        Task<Producer> DeleteProducer(int id);
        Task<Producer> UpdateProducer(int id, ProducerFormDto producerForm);
    }
}
