using MielczarekFurniture.Models.Dtos;

namespace MielczarekFurniture.UI.Services.Contracts
{
    public interface IProducerService
    {
        Task<IEnumerable<ProducerDto>> GetProducers();
        Task<ProducerDto> GetProducer(int id);
        Task<ProducerDto> AddProducer(ProducerFormDto producerForm);
        Task<ProducerDto> UpdateProducer(int id, ProducerFormDto producerForm);
        Task<ProducerDto> DeleteProducer(int id);

    }
}
