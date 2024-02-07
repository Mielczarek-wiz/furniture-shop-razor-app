using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;
using System.Net.Http.Json;

namespace MielczarekFurniture.UI.Services
{
    public class ProducerService : IProducerService
    {
        private readonly HttpClient httpClient;

        public ProducerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProducerDto>> GetProducers()
        {
            try
            {
                var response = await httpClient.GetAsync("api/Producer");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProducerDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProducerDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }

            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
        public async Task<ProducerDto> GetProducer(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Producer/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }
                    return await response.Content.ReadFromJsonAsync<ProducerDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }

        public async Task<ProducerDto> AddProducer(ProducerFormDto producerForm)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync<ProducerFormDto>("api/Producer", producerForm);
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }
                    return await response.Content.ReadFromJsonAsync<ProducerDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProducerDto> UpdateProducer(int id, ProducerFormDto producerForm)
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync<ProducerFormDto>($"api/Producer/{id}", producerForm);
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }
                    return await response.Content.ReadFromJsonAsync<ProducerDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProducerDto> DeleteProducer(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Producer/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<ProducerDto>();
                }
                return default;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
